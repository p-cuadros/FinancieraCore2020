Feature: Como cliente quiero iniciar sesión en el aplicativo para relaizarlas operaciones

Scenario: Cliente ingresa un usuario y clave y el inicio de sesion es errado
	Given el usuario u12345
    And y la clave 123123
	When se hace click en iniciar sesion
	Then el usuario permanece en la misma pagina
