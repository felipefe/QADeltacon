﻿#language:pt

Funcionalidade: Login

@abrir_navegador
Cenário: abrir navegador
Quando o sistema rodar
Então acessar a pagina inicial

@inserir_login
Cenario: login no sistema
Dado que o navegador chrome esteja aberto
Quando for clicado no botão entrar
Então logar no sistema

