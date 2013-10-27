<?xml version="1.0" encoding="utf-8"?>
<serviceModel xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" name="Wcf.Azure4" generation="1" functional="0" release="0" Id="e7ff5d23-046c-4e04-aa0a-8a5ccc31c398" dslVersion="1.2.0.0" xmlns="http://schemas.microsoft.com/dsltools/RDSM">
  <groups>
    <group name="Wcf.Azure4Group" generation="1" functional="0" release="0">
      <componentports>
        <inPort name="Wcf:Endpoint1" protocol="http">
          <inToChannel>
            <lBChannelMoniker name="/Wcf.Azure4/Wcf.Azure4Group/LB:Wcf:Endpoint1" />
          </inToChannel>
        </inPort>
      </componentports>
      <settings>
        <aCS name="Wcf:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="">
          <maps>
            <mapMoniker name="/Wcf.Azure4/Wcf.Azure4Group/MapWcf:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </maps>
        </aCS>
        <aCS name="WcfInstances" defaultValue="[1,1,1]">
          <maps>
            <mapMoniker name="/Wcf.Azure4/Wcf.Azure4Group/MapWcfInstances" />
          </maps>
        </aCS>
      </settings>
      <channels>
        <lBChannel name="LB:Wcf:Endpoint1">
          <toPorts>
            <inPortMoniker name="/Wcf.Azure4/Wcf.Azure4Group/Wcf/Endpoint1" />
          </toPorts>
        </lBChannel>
      </channels>
      <maps>
        <map name="MapWcf:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" kind="Identity">
          <setting>
            <aCSMoniker name="/Wcf.Azure4/Wcf.Azure4Group/Wcf/Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </setting>
        </map>
        <map name="MapWcfInstances" kind="Identity">
          <setting>
            <sCSPolicyIDMoniker name="/Wcf.Azure4/Wcf.Azure4Group/WcfInstances" />
          </setting>
        </map>
      </maps>
      <components>
        <groupHascomponents>
          <role name="Wcf" generation="1" functional="0" release="0" software="C:\Users\BrentProost\Documents\Projectjes\MM Systems\PanoramaApp3\Wcf.Azure4\csx\Release\roles\Wcf" entryPoint="base\x64\WaHostBootstrapper.exe" parameters="base\x64\WaIISHost.exe " memIndex="1792" hostingEnvironment="frontendadmin" hostingEnvironmentVersion="2">
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
            <sCSPolicyIDMoniker name="/Wcf.Azure4/Wcf.Azure4Group/WcfInstances" />
            <sCSPolicyUpdateDomainMoniker name="/Wcf.Azure4/Wcf.Azure4Group/WcfUpgradeDomains" />
            <sCSPolicyFaultDomainMoniker name="/Wcf.Azure4/Wcf.Azure4Group/WcfFaultDomains" />
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
    <implementation Id="4deb0bc6-633a-4744-9ef9-52d8c7c617a0" ref="Microsoft.RedDog.Contract\ServiceContract\Wcf.Azure4Contract@ServiceDefinition">
      <interfacereferences>
        <interfaceReference Id="5787f594-807e-4a64-8d09-3cf9823b00cf" ref="Microsoft.RedDog.Contract\Interface\Wcf:Endpoint1@ServiceDefinition">
          <inPort>
            <inPortMoniker name="/Wcf.Azure4/Wcf.Azure4Group/Wcf:Endpoint1" />
          </inPort>
        </interfaceReference>
      </interfacereferences>
    </implementation>
  </implements>
</serviceModel>