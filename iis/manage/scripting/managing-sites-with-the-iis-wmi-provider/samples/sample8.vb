Set oIIS = GetObject("winmgmts:root\WebAdministration")
' Create a binding for the site
Set oBinding = oIIS.Get("BindingElement").SpawnInstance_
oBinding.BindingInformation = "*:80:www.newsite.com"
oBinding.Protocol = "http"
' These are the parameters we pass to the Create method
name = "NewSite"
physicalPath = "C:\inetpub\wwwroot"
arrBindings = array(oBinding)
' Get the Site object definition
Set oSiteDefn = oIIS.Get("Site")
' Create site!!
oSiteDefn.Create name, arrBindings, physicalPath
WScript.Echo "Site created successfully!"