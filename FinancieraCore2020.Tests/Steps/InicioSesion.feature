Feature: Como cliente quiero iniciar sesión en el aplicativo para relaizarlas operaciones

Scenario: Cliente ingresa un usuario errado y clave errada y el inicio de sesion es errado
	Given el usuario 12345
    And y la clave 123123
	When se hace click en iniciar sesion
	Then el usuario permanece en la misma pagina

Scenario: Cliente ingresa un usuario correcto y clave errada y el inicio de sesion es errado
	Given el usuario User123
    And y la clave 123123
	When se hace click en iniciar sesion
	Then se muestra mensaje de error en la pagina