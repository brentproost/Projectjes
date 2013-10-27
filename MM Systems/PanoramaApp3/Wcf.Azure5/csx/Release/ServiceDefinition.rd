<?xml version="1.0" encoding="utf-8"?>
<serviceModel xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" name="Wcf.Azure5" generation="1" functional="0" release="0" Id="bddf85a0-2499-4f6a-a90a-cea7e0fac35d" dslVersion="1.2.0.0" xmlns="http://schemas.microsoft.com/dsltools/RDSM">
  <groups>
    <group name="Wcf.Azure5Group" generation="1" functional="0" release="0">
      <componentports>
        <inPort name="Wcf:Endpoint1" protocol="http">
          <inToChannel>
            <lBChannelMoniker name="/Wcf.Azure5/Wcf.Azure5Group/LB:Wcf:Endpoint1" />
          </inToChannel>
        </inPort>
      </componentports>
      <settings>
        <aCS name="Wcf:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="">
          <maps>
            <mapMoniker name="/Wcf.Azure5/Wcf.Azure5Group/MapWcf:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </maps>
        </aCS>
        <aCS name="WcfInstances" defaultValue="[1,1,1]">
          <maps>
            <mapMoniker name="/Wcf.Azure5/Wcf.Azure5Group/MapWcfInstances" />
          </maps>
        </aCS>
      </settings>
      <channels>
        <lBChannel name="LB:Wcf:Endpoint1">
          <toPorts>
            <inPortMoniker name="/Wcf.Azure5/Wcf.Azure5Group/Wcf/Endpoint1" />
          </toPorts>
        </lBChannel>
      </channels>
      <maps>
        <map name="MapWcf:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" kind="Identity">
          <setting>
            <aCSMoniker name="/Wcf.Azure5/Wcf.Azure5Group/Wcf/Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </setting>
        </map>
        <map name="MapWcfInstances" kind="Identity">
          <setting>
            <sCSPolicyIDMoniker name="/Wcf.Azure5/Wcf.Azure5Group/WcfInstances" />
          </setting>
        </map>
      </maps>
      <components>
        <groupHascomponents>
          <role name="Wcf" generation="1" functional="0" release="0" software="C:\Users\BrentProost\Documents\Projectjes\MM Systems\PanoramaApp3\Wcf.Azure5\csx\Release\roles\Wcf" entryPoint="base\x64\WaHostBootstrapper.exe" parameters="base\x64\WaIISHost.exe " memIndex="1792" hostingEnvironment="frontendadmin" hostingEnvironmentVersion="2">
            <componentports>
              <inPort name="Endpoint1" protocol="http" portRanges="80" />
            </componentports>
            <settings>
              <aCS name="Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="" />
              <aCS name="__ModelData" defaultValue="&lt;m role=&quot;Wcf&quot; xmlns=&quot;urn:azure:m:v1&quot;&gt;&lt;r name=&quot;Wcf&quot;&gt;&lt;e name=&quot;Endpoint1&quot; /&gt;&lt;/r&gt;&lt;/m&gt;" />
            </settings>
            <resourcereferences>
              <resourceReference name="DiagnosticStore" defaultAmount="[4096,4096,4096]" defaultSticky="true" kind="Directory" />
              <resourceReference name="EventStore" defaultAmount="[1000,1000,1000]" defaultSticky="false" kind="LogStore" />
            </resourcereferences>
          </role>
          <sCSPolicy>
            <sCSPolicyIDMoniker name="/Wcf.Azure5/Wcf.Azure5Group/WcfInstances" />
            <sCSPolicyUpdateDomainMoniker name="/Wcf.Azure5/Wcf.Azure5Group/WcfUpgradeDomains" />
            <sCSPolicyFaultDomainMoniker name="/Wcf.Azure5/Wcf.Azure5Group/WcfFaultDomains" />
          </sCSPolicy>
        </groupHascomponents>
      </components>
      <sCSPolicy>
        <sCSPolicyUpdateDomain name="WcfUpgradeDomains" defaultPolicy="[5,5,5]" />
        <sCSPolicyFaultDomain name="WcfFaultDomains" defaultPolicy="[2,2,2]" />
        <sCSPolicyID name="WcfInstances" defaultPolicy="[1,1,1]" />
      </sCSPolicy>
    </group>
  </groups>
  <implements>
    <implementation Id="3c452fd3-d597-4704-a982-bc60ef64da62" ref="Microsoft.RedDog.Contract\ServiceContract\Wcf.Azure5Contract@ServiceDefinition">
      <interfacereferences>
        <interfaceReference Id="0ca203ee-37fb-4651-a66f-8157057c6373" ref="Microsoft.RedDog.Contract\Interface\Wcf:Endpoint1@ServiceDefinition">
          <inPort>
            <inPortMoniker name="/Wcf.Azure5/Wcf.Azure5Group/Wcf:Endpoint1" />
          </inPort>
        </interfaceReference>
      </interfacereferences>
    </implementation>
  </implements>
</serviceModel>