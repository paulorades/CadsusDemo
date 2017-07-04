# CadsusDemo

Este projeto é um estudo de como se utilizar o ambiente de Homologação do CADSUS, realizando operações no barramento PIX-PDQ.

A documentação oficial fornecida pelo DATASUS pode ser encontrada em: http://datasus.saude.gov.br/interoperabilidade/catalogo-de-servicos.

Visa-se a realização das operações de forma simplificada, sem emprego design patterns ou layers.

A aplicação consiste de formulários Windows Forms que consomem o webservice (https://servicoshm.saude.gov.br/cadsus/CadsusService/v5r0?wsdl).

* É necessário adicionar uma referência para "System.Configuration"
* Para realizar a autenticação, é necessário adicionar a seguinte tag dentro do custombinding utilizado no app.Config (veja em App.Config):
<security enableUnsecuredResponse="true" authenticationMode="UserNameOverTransport"/>, do contrário o erro "as credenciais informadas não são válidas" irá ocorrer.

Tudo aqui é apresentado em caráter de teste e pesquisa, não devendo ser considerado como otimizado para um ambiente de produção.