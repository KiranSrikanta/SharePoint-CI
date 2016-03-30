Add-PSSnapin Microsoft.SharePoint.PowerShell

write-host "Running the deployment script."

$solution = Get-SPSolution -Identity spcisolution.wsp

if ($solution){
    write-host "Retracting the previous solution."
    Uninstall-SPSolution -Identity SpCiSolution.wsp –WebApplication http://test2012 -Confirm:$false
    while($solution.JobExists) {
        write-host "Retracting..."
        Start-Sleep -s 10
    }

    write-host "Removing the previous solution."
    Remove-SPSolution -Identity SpCiSolution.wsp -Confirm:$false
}


function Get-ScriptDirectory
{
    $Invocation = (Get-Variable MyInvocation -Scope 1).Value
    Split-Path $Invocation.MyCommand.Path
}

$curr_dir = Get-ScriptDirectory
$soln_path = $curr_dir + "\WSPs\SpCiSolution.wsp"
write-host $soln_path

Add-SPSolution -LiteralPath $soln_path

Install-SPSolution –Identity SpCiSolution.wsp –WebApplication http://test2012 -GACDeployment

write-host "Deployemnt script finished execution."