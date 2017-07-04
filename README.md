# CadsusDemo

Este projeto � um estudo de como se utilizar o ambiente de Homologa��o do CADSUS, realizando opera��es no barramento PIX-PDQ.

A documenta��o oficial fornecida pelo DATASUS pode ser encontrada em: http://datasus.saude.gov.br/interoperabilidade/catalogo-de-servicos.

Visa-se a realiza��o das opera��es de forma simplificada, sem emprego design patterns ou layers.

A aplica��o consiste de formul�rios Windows Forms que consomem o webservice (https://servicoshm.saude.gov.br/cadsus/CadsusService/v5r0?wsdl).

* � necess�rio adicionar uma refer�ncia para "System.Configuration"
* Para realizar a autentica��o, � necess�rio adicionar a seguinte tag dentro do custombinding utilizado no app.Config (veja em App.Config):
<security enableUnsecuredResponse="true" authenticationMode="UserNameOverTransport"/>, do contr�rio o erro "as credenciais informadas n�o s�o v�lidas" ir� ocorrer.

Tudo aqui � apresentado em car�ter de teste e pesquisa, n�o devendo ser considerado como otimizado para um ambiente de produ��o.