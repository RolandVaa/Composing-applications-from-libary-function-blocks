<?xml version="1.0" encoding="utf-8"?>
<!DOCTYPE AdapterType SYSTEM "../LibraryElement.dtd">
<AdapterType GUID="cd248650-c0e7-4915-a997-f390f32e406f" Name="AdpChan" Comment="Adapter Interface" Namespace="Main">
  <Identification Standard="61499-1" />
  <VersionInfo Organization="nxtControl GmBH" Version="0.0" Author="valeriy" Date="7/14/2023" />
  <InterfaceList>
    <EventInputs>
      <Event Name="EI0" Comment="Request from Socket">
        <With Var="DI1" />
        <With Var="DI2" />
        <With Var="DI3" />
      </Event>
      <Event Name="EI1" Comment="Response from Socket">
        <With Var="DI1" />
        <With Var="DI2" />
        <With Var="DI3" />
      </Event>
      <Event Name="EI2">
        <With Var="DI1" />
        <With Var="DI2" />
        <With Var="DI3" />
      </Event>
    </EventInputs>
    <EventOutputs>
      <Event Name="EO0" Comment="Confirmation from Plug">
        <With Var="DO0" />
        <With Var="DO1" />
        <With Var="DO2" />
        <With Var="DO3" />
      </Event>
      <Event Name="EO1" Comment="Indication from Plug">
        <With Var="DO0" />
        <With Var="DO1" />
        <With Var="DO2" />
        <With Var="DO3" />
      </Event>
      <Event Name="EO2">
        <With Var="DO0" />
        <With Var="DO1" />
        <With Var="DO2" />
        <With Var="DO3" />
      </Event>
    </EventOutputs>
    <InputVars>
      <VarDeclaration Name="DI1" Type="STRING" Comment="Request Data from Socket" />
      <VarDeclaration Name="DI2" Type="STRING" Comment="Response Data from Socket" />
      <VarDeclaration Name="DI3" Type="STRING" />
    </InputVars>
    <OutputVars>
      <VarDeclaration Name="DO0" Type="BOOL" />
      <VarDeclaration Name="DO1" Type="STRING" Comment="Confirmation Data from Plug" />
      <VarDeclaration Name="DO2" Type="STRING" Comment="Indication Data from Plug" />
      <VarDeclaration Name="DO3" Type="STRING" />
    </OutputVars>
  </InterfaceList>
  <Service RightInterface="PLUG" LeftInterface="SOCKET">
    <ServiceSequence Name="request_confirm">
      <ServiceTransaction>
        <InputPrimitive Interface="SOCKET" Event="EI0" Parameters="DI1" />
        <OutputPrimitive Interface="PLUG" Event="EI0" Parameters="DI1" />
      </ServiceTransaction>
      <ServiceTransaction>
        <InputPrimitive Interface="PLUG" Event="EO0" Parameters="DO1" />
        <OutputPrimitive Interface="SOCKET" Event="EO0" Parameters="DO1" />
      </ServiceTransaction>
    </ServiceSequence>
    <ServiceSequence Name="indication_response">
      <ServiceTransaction>
        <InputPrimitive Interface="PLUG" Event="EO1" Parameters="DO2" />
        <OutputPrimitive Interface="SOCKET" Event="EO1" Parameters="DO2" />
      </ServiceTransaction>
      <ServiceTransaction>
        <InputPrimitive Interface="SOCKET" Event="EI1" Parameters="DI2" />
        <OutputPrimitive Interface="PLUG" Event="EI1" Parameters="DI2" />
      </ServiceTransaction>
    </ServiceSequence>
  </Service>
</AdapterType>