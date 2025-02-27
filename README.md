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

