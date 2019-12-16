# Stone - Extrato Bancário
Web Api com base no pattern DDD e Repository, com validação na camada de modelo, testes unitários e de integracão.
Web Api documentada com Swagger e dockerizada com orquestrador compose.

## Etapas para gerar um container local (Docker).
1.	Compilar o projeto (a patir do menu Build > Build Solution) ou pelo comando no VSCODE(dotnet build => docker build -t bankstatementapi .);
2.	Executar o comando docker images no PowerShell (docker image ls);
a.	Será exibido o repositório com o nome bankstatementapi e tag latest.
3.	Crie o container da imagem com o comando, docker-compose up;
