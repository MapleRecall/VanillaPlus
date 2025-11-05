param(
    [Parameter(Mandatory=$true)]
    [string]$StringsFilePath,
    
    [Parameter(Mandatory=$true)]
    [string]$OutputJsonPath
)

$ErrorActionPreference = "Stop"

Write-Host "Generating loc_en.json from Strings.cs..." -ForegroundColor Cyan
Write-Host "  Source: $StringsFilePath" -ForegroundColor Gray
Write-Host "  Output: $OutputJsonPath" -ForegroundColor Gray

if (-not (Test-Path $StringsFilePath)) {
    Write-Error "Strings.cs file not found at: $StringsFilePath"
    exit 1
}

try {
    # Read the Strings.cs file
    $content = Get-Content -Path $StringsFilePath -Raw -Encoding UTF8
    
    # Dictionary to store localization entries
    $entries = [ordered]@{}
    
    # Split into lines for processing
    $lines = $content -split "`r?`n"
    
    $i = 0
    while ($i -lt $lines.Count) {
        $line = $lines[$i]
        
        # Check if line contains Localization.Localize
        if ($line -match 'Localization\.Localize') {
            # Extract the key
            if ($line -match 'Localization\.Localize\s*\(\s*"([^"]+)"') {
                $key = $Matches[1]
                
                # Build the complete statement (might span multiple lines)
                $statement = $line
                while (-not ($statement -match '\);') -and $i -lt $lines.Count - 1) {
                    $i++
                    $statement += " " + $lines[$i].Trim()
                }
                
                # Extract all quoted strings after the key
                $quotedStrings = [regex]::Matches($statement, '"([^"]*)"') | ForEach-Object { $_.Groups[1].Value }
                
                # First string is the key, rest are the value parts
                if ($quotedStrings.Count -ge 2) {
                    $valueParts = $quotedStrings | Select-Object -Skip 1
                    $value = ($valueParts -join '') 
                    
                    # Handle escape sequences
                    $value = $value -replace '\\n', "`n"
                    $value = $value -replace '\\t', "`t"
                    $value = $value -replace '\\"', '"'
                    $value = $value -replace '\\\\', '\'
                    
                    $entries[$key] = $value
                }
            }
        }
        
        $i++
    }
    
    Write-Host "Found $($entries.Count) localization entries" -ForegroundColor Green
    
    # Create JSON structure
    $jsonObject = [ordered]@{}
    
    foreach ($key in $entries.Keys) {
        $jsonObject[$key] = @{
            "message" = $entries[$key]
        }
    }
    
    # Convert to JSON with proper formatting (2 space indent by default)
    $json = $jsonObject | ConvertTo-Json -Depth 10
    
    # Change indentation from 2 spaces to 4 spaces to match .editorconfig
    # Process line by line to correctly convert indentation
    $lines = $json -split "`r?`n"
    $convertedLines = $lines | ForEach-Object {
        if ($_ -match '^( +)(.*)$') {
            $spaces = $Matches[1]
            $content = $Matches[2]
            $indentLevel = $spaces.Length / 2  # PowerShell's ConvertTo-Json uses 2-space indent
            $newIndent = '    ' * $indentLevel  # Convert to 4-space indent
            "$newIndent$content"
        } else {
            $_
        }
    }
    $json = $convertedLines -join "`n"
    
    # Ensure output directory exists
    $outputDir = Split-Path -Parent $OutputJsonPath
    if ($outputDir -and -not (Test-Path $outputDir)) {
        New-Item -ItemType Directory -Path $outputDir -Force | Out-Null
    }
    
    # Write to file with UTF8 encoding (no BOM)
    $utf8NoBom = New-Object System.Text.UTF8Encoding $false
    [System.IO.File]::WriteAllText($OutputJsonPath, $json, $utf8NoBom)
    
    Write-Host "Successfully generated: $OutputJsonPath" -ForegroundColor Green
    exit 0
}
catch {
    Write-Error "Error generating localization file: $_"
    Write-Error $_.ScriptStackTrace
    exit 1
}
