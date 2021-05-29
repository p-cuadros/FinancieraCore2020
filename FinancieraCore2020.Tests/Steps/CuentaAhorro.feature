Feature: Como cliente quiere realizar depositos y retiros para modificar mi saldo de cuenta

Scenario: Cliente deposita en su cuenta un monto y es correcto
	Given la cuenta nueva numero 00001 con 7.5
	When yo deposito S/ 10
	Then el saldo nuevo deberia ser 10

Scenario: Cliente retiro en su cuenta un monto y es correcto
	Given la cuenta nueva numero 00001 con 7.5
    And con saldo S/ 10
	When yo retiro S/ 10
	Then el saldo nuevo deberia ser 0
