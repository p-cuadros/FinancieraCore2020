Feature: Como cliente quiere realizar depositos y retiros para modificar mi saldo de cuenta

Scenario: Cliente deposita en su cuenta un monto y es correcto
	Given la nueva cuenta numero 12345
	When deposito 10
	Then el saldo nuevo deberia ser 10

Scenario: Cliente retira en su cuenta un monto y es correcto
	Given la nueva cuenta numero 12345
    And con saldo 10
	When retiro 10
	Then el saldo nuevo deberia ser 0
