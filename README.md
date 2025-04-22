# 🟦 Aplicativo .NET MAUI com Troca de Tema Dinâmica

Este é um aplicativo desenvolvido com **.NET MAUI** que demonstra a implementação de **temas dinâmicos** utilizando **dicionários de recursos (ResourceDictionary)**. 

## 🎯 Desafio

O desafio principal foi criar um **botão que trocasse o tema de todo o aplicativo**, incluindo:

- Cor de fundo
- Cores de texto
- Cores principais da interface

## ✨ Funcionalidades

- 🎨 **Troca de tema em tempo real:** Alternância entre temas com um clique.
- 🧩 **Uso de ResourceDictionary:** Organização dos temas em arquivos separados.
- 📱 **Multiplataforma com .NET MAUI:** Funciona em Android, iOS, Windows e Mac.

## ⚙️ Como Funciona

1. Os temas são definidos em arquivos XAML como `LightTheme.xaml` e `DarkTheme.xaml`.
2. O aplicativo carrega um dos dicionários como tema padrão.
3. Ao clicar no botão de troca, o app:
   - Remove o tema atual
   - Adiciona o novo dicionário de tema
   - Aplica as mudanças dinamicamente

```csharp
Application.Current.Resources.MergedDictionaries.Clear();
Application.Current.Resources.MergedDictionaries.Add(new DarkTheme());
