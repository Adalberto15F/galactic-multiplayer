# 🌌 Galactic Multiplayer  

## 📖 Sobre o Projeto

### 🎯 Objetivo  
O **Galactic Multiplayer** é um jogo multiplayer online onde os jogadores exploram o espaço e enfrentam desafios em tempo real. Ele foi desenvolvido para estudar e aplicar conceitos de redes e jogos distribuídos usando **Unity** e **Photon Fusion**.

### 🛠️ Tecnologias Utilizadas  
- **Unity** 🟦 – Motor gráfico e de desenvolvimento do jogo  
- **Photon Fusion** ⚡ – Framework de multiplayer para sincronização em tempo real  
- **C#** 🔷 – Linguagem de programação utilizada no desenvolvimento  

### 🏗️ Estrutura do Projeto  
O projeto é composto por várias partes essenciais, incluindo:

#### 🔹 Gerenciamento de Salas  
As salas são criadas e gerenciadas pelo **Photon Fusion**, permitindo que múltiplos jogadores (até 4 jogadores) entrem e interajam no mesmo ambiente.  

#### 🔹 Sincronização dos Jogadores  
Cada jogador tem sua posição e ações sincronizadas usando **Network Objects**, garantindo uma experiência fluida e sem atrasos perceptíveis(dependeo da internet vai ter um poucode atraso).  

#### 🔹 Interação Multiplayer  
O jogo utiliza **RPCs (Remote Procedure Calls)** e sincronização de estado para garantir que todas as ações dos jogadores sejam refletidas corretamente em todas as instâncias conectadas.  

## 📨 Implementação do Chat e Simulação de Latência  

No **Galactic Multiplayer**, a comunicação entre os jogadores é essencial para a experiência multiplayer. O chat foi implementado utilizando **Photon Fusion**, garantindo que as mensagens sejam enviadas e recebidas em tempo real, mesmo em condições de latência variável.  


# 🏗️ Como o Chat Funciona  

### 1️⃣ Envio de Mensagens  
- Cada jogador pode digitar uma mensagem e enviá-la para todos na sala.  
- As mensagens são transmitidas via **RPCs (Remote Procedure Calls)**, garantindo que todos os jogadores conectados recebam a informação simultaneamente.  

### 2️⃣ Sincronização entre os Jogadores  
- O sistema de **Network Objects** do Photon Fusion mantém o estado do chat atualizado para todos os jogadores.  
- Mesmo que um jogador entre na sala após o início da conversa, ele recebe as mensagens anteriores armazenadas no buffer.  

#### 🛠️ Como foi testado?  
- Criamos um objeto chamado `FusionStats`, que exibe estatísticas de rede, incluindo o **ping** (tempo de ida e volta dos pacotes).  
- Para visualizar o impacto do lag no jogo, rodamos o servidor e adicionamos atraso nas mensagens utilizando o Clumsy.  

#### 📊 Resultados Observados  
- **Sem lag**, as mensagens do chat aparecem instantaneamente.  
- Com latência artificial de **70ms**, ainda conseguimos uma experiência fluida graças ao **client prediction** do Photon Fusion, que antecipa eventos como movimentação e disparos no jogo.  
- Quando a latência é removida, a comunicação volta ao normal imediatamente.  


## 🛠️ Como Rodar o Projeto  

### Abra o projeto no Unity  
- **Recomendado:** Unity `2022.3.25f1` (versão compatível)  
- Certifique-se de instalar o **Photon Fusion** via **Package Manager**  

### Configure o Photon Fusion  
1. Vá para `Assets > Photon > Fusion > FusionAppSettings.asset`  
2. Insira a **App ID** do Photon (registre-se no [Photon Engine](photonengine.com))  

### Compile e Rode 🚀  
- Clique em **Play** no Unity  
- Para testes multiplayer, abra **duas instâncias** do jogo ou use o **Photon Fusion Simulation Mode**  

## 🏗️ Estrutura do Projeto  
📂 `Assets/` → Arquivos principais do jogo  
📂 `Scripts/` → Código-fonte do jogo  
📂 `Prefabs/` → Modelos pré-configurados de objetos e personagens  

## 🤝 Contribuição  
Sinta-se à vontade para abrir **Issues** ou fazer um **Pull Request**!  

