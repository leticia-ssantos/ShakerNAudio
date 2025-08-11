# ShakerNAudio

ShakerNAudio é uma aplicação Windows Forms desenvolvida em C# (.NET Framework 4.7.2) que utiliza a biblioteca NAudio para geração e manipulação de áudio em tempo real.

## Funcionalidades Principais

- Geração de Onda Senoidal:

Permite gerar sinais de áudio do tipo seno, com frequência e volume ajustáveis pelo usuário.

- Controle de Frequência e Volume:

O usuário pode ajustar a frequência (Hz) e o ganho (volume) do sinal gerado através de controles deslizantes (trackbars).

- Panorama Estéreo (Panning):

Possibilita ajustar o balanço do áudio entre os canais esquerdo e direito, simulando diferentes posições no campo estéreo.

- Seleção de Dispositivo de Saída:

Lista todos os dispositivos de saída de áudio disponíveis no sistema, permitindo ao usuário escolher por onde o áudio será reproduzido.

- Início e Parada da Reprodução:

Botão para iniciar e parar a reprodução do áudio gerado.

- Portamento (Transição Suave de Frequência):

Ao alterar a frequência, a transição ocorre de forma suave, sem cortes abruptos no som.

## Estrutura do Projeto

- ShakerNAudio.cs:
Formulário principal da aplicação, responsável pela interface gráfica e integração dos controles com a lógica de áudio.
- SineWaveProvider.cs:
Classe responsável por gerar amostras de áudio com forma de onda senoidal, suportando portamento e controle de volume.
- Dependências:
- NAudio: Biblioteca para manipulação de áudio em .NET.
  
## Como Usar

1.	Execute o aplicativo.
2.	Selecione o dispositivo de saída de áudio desejado.
3.	Ajuste a frequência, volume e panorama conforme necessário.
4.	Clique em "Play" para iniciar a reprodução e "Stop" para parar.
