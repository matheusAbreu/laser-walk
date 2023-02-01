# Laser Walk

## Trabalho AV2 de Física 3 - UERJ-ZO

## Como jogar
>Mova os espelhos de maneira a fazer com que o laser atinja o alvo(torre verde)

>Após atingir o alvo, o jogo lhe passa para o próximo nivel, ao conclur o 3º nivel, o jogo lhe retornará ao menu


### Bugs conhecidos no jogo
1. Laser limitado
	- No meio do desenvolvimento o raio limitou-se a um tamanho que é aproximadamente 3/4 da fase.
	- Ao entrar em contato com um espelho o raio consegue até dobrar de tamanho, ao colidir com um terceiro ele aumenta mas não chega a triplicar. ou seja: o espelhos alongam o raio, mas num multiplicador ainda indefinido.

2. Espelho concavo na 3º fase
    - Na 3ª fase, ao utilizar o espelho concavo, acaba sendo possivel refletir o raio para cima (ganhando posicionamento(incremento) no eixo Y), isso é devido a algum refinamento de altura no espelho e/ou raio.


### Build você mesmo

É possivel baixar o projeto em sua [página no github](https://github.com/matheusAbreu/laser-walk.git) e o mesmo está sendo desenvolvido na [Unity](https://unity.com/pt/download) versão 2021.3.17f1(Personal) e não é garantido a execução do mesmo em qualquer outra versão.

