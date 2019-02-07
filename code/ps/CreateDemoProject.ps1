$workDir = pwd
$tempDir = "C:\temp\IntroToFSharp"
[System.IO.Directory]::CreateDirectory($tempDir)
cd $tempDir

$demoDir = "Demo"
$demoName = "Demo"
dotnet new console -lang "F#" --name $demoName --output $demoDir

dotnet new sln --name IntroToFSharp
dotnet sln add .\$demoDir\$demoName`.fsproj

cd $demoDir
dotnet add package FSharp.Data --version 3.0.0 
dotnet add package FSharp.Text.RegexProvider --version 1.0.0 
dotnet add package SQLProvider --version 1.1.58

dotnet restore

cd $workDir