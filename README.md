# 🚀 Lista de Exercicios II em C# .NET — Terminal de Suporte Proativo

![Status](https://img.shields.io/badge/status-concluido-green)
![Plataforma](https://img.shields.io/badge/platform-Windows%20%7C%20Linux-blue)
![Tecnologia](https://img.shields.io/badge/C%23-.NET%208%20console-purple)

---

## 📖 Sobre o Projeto

Este repositorio documenta a implementacao da **Lista de Exercicios II** da disciplina **Interacao Humano Computador e UX**, desenvolvida no contexto academico do **Centro Universitario UNA**, sob orientacao do **Professor Daniel Henrique Matos de Paiva**.

O projeto foi desenvolvido em **C# com .NET 8**, no formato **console application**, com foco em **acessibilidade**, **prevencao de erros** e **clareza na interacao**.

O exercicio propoe a criacao de um prototipo chamado **TerminalSuporte.ConsoleApp**, simulando um console de diagnostico de rede utilizado por tecnicos de TI.

O problema inicial do sistema era claro:

- comandos dificeis de memorizar
- mensagens de erro vagas
- ausencia de ajuda contextual
- risco de executar acoes criticas sem confirmacao adequada

A solucao implementada busca reduzir esses problemas com base em **heuristicas de Nielsen**, utilizando menu visivel, ajuda integrada, validacoes e uso de cores para estados importantes.

---

## 🎯 Objetivo da Atividade

Desenvolver uma aplicacao console em C# capaz de ajudar um tecnico a diagnosticar um servidor, priorizando:

- acessibilidade no fluxo de uso
- prevencao de erros em operacoes criticas
- reconhecimento de comandos em vez de memorizacao
- ajuda e documentacao sem interromper a navegacao
- resiliencia diante de entradas invalidas

---

## 🧩 Cenario Proposto

No exercicio pratico, o usuario interage com um terminal de suporte que oferece comandos rapidos para diagnostico e manutencao.

O prototipo simula funcoes como:

1. ping em um endereco IP
2. consulta de status do servidor
3. reinicio do servidor
4. formatacao de unidade

O sistema foi construido para orientar o usuario durante todo o processo, evitando erros e tornando a interface mais segura e compreensivel.

---

## ✅ Heuristicas Aplicadas

### 1. Heuristica #5 — Prevencao de Erros

Acoes criticas exigem confirmacao reforcada antes de serem executadas.

Exemplos:

- para reiniciar, o usuario precisa digitar exatamente `REINICIAR`
- para formatar, o usuario precisa informar a unidade e depois confirmar com `FORMATAR`

Esse cuidado reduz a chance de comandos perigosos serem disparados por engano.

### 2. Heuristica #6 — Reconhecimento em vez de Recordacao

O sistema exibe um **Menu de Comandos Rapidos** e uma **legenda fixa** com atalhos e comandos auxiliares.

Exemplo:

```text
Menu de Comandos Rapidos
1 - Pingar IP
2 - Ver status do servidor
3 - Reiniciar servidor
4 - Formatar unidade
5 - Sair
```

Com isso, o usuario nao precisa memorizar instrucoes complexas para operar o terminal.

### 3. Heuristica #10 — Ajuda e Documentacao

Os comandos `help` e `?` mostram explicacoes sobre as funcoes disponiveis sem tirar o usuario da tela atual.

Essa abordagem facilita o uso do sistema por quem esta aprendendo ou precisa de apoio rapido durante a execucao.

---

## 🎨 UX Writing, Cores e Resiliencia

O exercicio tambem valoriza a qualidade da comunicacao com o usuario e o tratamento adequado dos estados do sistema.

### UX Writing

As mensagens foram escritas de forma clara, orientativa e objetiva, evitando respostas secas como `Command Error`.

### Gestao de Cores

O console utiliza cores para destacar estados importantes:

- `verde` para sucesso
- `amarelo` para atencao
- `vermelho` para perigo e erros

### Resiliencia

O programa continua funcionando mesmo quando o usuario digita entradas inesperadas, como:

- IP com letras
- unidade em formato incorreto
- confirmacoes erradas em acoes criticas
- comandos fora do menu

---

## ⚙️ Estrutura do Projeto

O projeto foi mantido simples, com a logica principal centralizada em um unico arquivo.

### Estrutura

```text
ihcux-lista-02/
├── Program.cs
├── ihcux-lista-02.csproj
├── ihcux-lista-02.sln
└── README.md
```

### Descricao dos arquivos

- `Program.cs` -> contem toda a logica do terminal, incluindo menu, ajuda, validacoes, confirmacoes e mensagens com cores
- `ihcux-lista-02.csproj` -> arquivo de configuracao do projeto .NET
- `ihcux-lista-02.sln` -> arquivo da solution
- `README.md` -> documentacao do projeto

---

## 💻 Funcionalidades Implementadas

### 1. Pingar IP

Solicita ao usuario um endereco IP e valida o formato informado.

Se o dado estiver incorreto, o sistema orienta com a mensagem:

```text
IP invalido. Use o formato correto: xxx.xxx.xxx.xxx
```

### 2. Ver status do servidor

Simula uma consulta de status e exibe uma mensagem de retorno positiva para indicar o estado do servidor.

### 3. Reiniciar servidor

Apresenta um alerta em amarelo e exige confirmacao explicita antes da execucao.

### 4. Formatar unidade

Ativa o modo de alerta com destaque visual, solicita a unidade a ser formatada e exige uma segunda confirmacao antes de concluir a simulacao.

### 5. Ajuda contextual

Em diferentes telas, o usuario pode digitar `help` ou `?` para consultar instrucoes da funcao atual sem perder o contexto.

---

## ▶️ Como Executar

### Requisitos

- .NET 8 SDK instalado

### Executar o projeto

Na pasta raiz do repositorio, rode:

```bash
dotnet run
```

### Compilar o projeto

```bash
dotnet build
```

---

## 🧪 Exemplo de Fluxo

```text
=== TerminalSuporte.ConsoleApp ===
Menu de Comandos Rapidos
1 - Pingar IP
2 - Ver status do servidor
3 - Reiniciar servidor
4 - Formatar unidade
5 - Sair

Legenda fixa: help | ? = ajuda   menu = voltar ao menu   sair = encerrar
```

Esse formato reduz a necessidade de memorizacao e torna a navegacao mais intuitiva para o usuario.

---

## ✅ Conceitos Utilizados

- variaveis simples
- estruturas condicionais com `if` e `else if`
- estrutura de repeticao com `while`
- leitura de dados com `Console.ReadLine()`
- validacao com `int.TryParse`
- validacao de texto e formato
- uso de `ConsoleColor`
- mensagens instrutivas no console

---

## 💡 Boas Praticas Aplicadas

- foco em usabilidade desde a entrada ate a confirmacao
- mensagens claras e menos agressivas
- confirmacao extra para operacoes criticas
- menu sempre visivel para reconhecimento rapido
- ajuda integrada no proprio fluxo
- estrutura simples, legivel e adequada ao contexto academico

---

## 🚀 Aplicacao no Contexto Academico

Este exercicio mostra que um sistema de console pode ser projetado com preocupacao real com experiencia do usuario.

A atividade reforca conhecimentos importantes como:

- validacao de entradas
- organizacao do fluxo de interacao
- prevencao de erros
- acessibilidade em interfaces textuais
- uso de feedback visual
- aplicacao pratica de heuristicas de usabilidade

Mesmo sem interface grafica, o projeto demonstra como boas decisoes de UX fazem diferenca direta na seguranca e na compreensao do sistema.

---

## 🧩 Conclusao

O projeto entrega a proposta da **Lista de Exercicios II** com uma implementacao funcional, simples e alinhada ao enunciado.

A aplicacao prioriza seguranca, clareza e apoio ao usuario durante a navegacao, aplicando de forma pratica as heuristicas de Nielsen em um terminal de suporte proativo.

Com isso, o repositorio registra nao apenas a resolucao tecnica do exercicio, mas tambem a preocupacao com acessibilidade, prevencao de erros e qualidade da experiencia de uso.

---

## 👨‍💻 Autor

Lucas Cota  
Estudante de Analise e Desenvolvimento de Sistemas  
Foco em Backend e Engenharia de Software
