# Validacao_cpf_slp
Desenvolver um algoritmo simples de validação de CPF

## 

É precisa ter em mente que os dois ultimos digitos são digitos de validação,
o cpf possui 11 digitos no total, porem, para validade temos que deixar de fora
na primeira etapa os dois ultimos digitos pois eles irão confima se é ou não valido.

O cálculo de validação do CPF é bem direto. Ele funciona através de pesos associados a
cada número e uma divisão pelo número primo 11 ao final. Vamos vê-lo em etapas.

##

Começamos utilizando os 9 primeiros dígitos multiplicando-os pela sequência decrescente
de 10 à 2 e somamos esse resultado.

cpf de exemplo: 145.382.206-20

(1 X 10) + (4	X 9) + (5 X 8) + (3 X 7) +	(8 X 6) +	(2 X 5) + (2 X 4) + (0 X 3) + (6 X 2) = 185

185 % 11 = 9

11 - 9 = 2 <- primeiro digito de validação

com o resultado deste calculo vamos divilido por 11 e pegar seu resto de divição e sulbitrair por 11
resultando assim no valor correspondente ao primeiro digito de validação.

Como o resultado da da subtração foi 2, o primeiro dígito verificador é igual a 2. Caso o resultado
dessa divisão for 10 ou maior, o penúltimo dígito verificador será o 0.

##

A validação do segundo dígito é semelhante a primeira, porém vamos considerar o primeiro dígito
verificador calculado anteriormente. Por isso a multiplicação é feita de 11 à 2


(1 X 11)	+ (4 X 10)	+ (5 X 9)	+ (3 X 8)	+ (8 X 7)	+ (2 X 6)	+ (2 X 5)	+ (0 X 4)	+ (6 X 3)	+ (2 X 2) = 220

220 % 11 = 0

11 - 0 = 11

Como o valor é igual ou maior que 10, o último dígito é 0.
