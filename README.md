# expert-octo-system
WinForms WebView2 Demo Application

## Description
Cette application WinForms démontre l'utilisation du contrôle WebView2 pour afficher du contenu web dans une application Windows native.

## Prérequis

### Visual Studio 2022
- Visual Studio 2022 avec le workload ".NET desktop development"
- .NET 8.0 SDK ou supérieur

### WebView2 Runtime
Le WebView2 Runtime est nécessaire pour exécuter cette application. Il est généralement pré-installé sur Windows 10 et 11.

#### Vérification du Runtime
Pour vérifier si le WebView2 Runtime est installé :
1. Ouvrez `Paramètres Windows` > `Applications` > `Applications et fonctionnalités`
2. Recherchez "Microsoft Edge WebView2 Runtime"

#### Installation du Runtime
Si le runtime n'est pas installé :
- **Option 1 (Recommandé)** : Téléchargez le Runtime Evergreen depuis [Microsoft](https://developer.microsoft.com/microsoft-edge/webview2/#download-section)
- **Option 2** : Le package NuGet `Microsoft.Web.WebView2` inclut automatiquement le runtime dans votre application

## Structure du Projet

```
WebView2App/
├── WebView2App.sln          # Fichier solution Visual Studio
└── WebView2App/
    ├── WebView2App.csproj   # Fichier projet avec dépendances NuGet
    ├── Program.cs           # Point d'entrée de l'application
    ├── Form1.cs             # Code-behind du formulaire principal
    └── Form1.Designer.cs    # Code généré par le designer
```

## Dépendances NuGet

- **Microsoft.Web.WebView2** (v1.0.2739.15) : SDK pour le contrôle WebView2

## Fonctionnalités

1. **Fenêtre principale** avec un contrôle WebView2
2. **Bouton "Charger URL (jobup.ch)"** pour naviguer vers https://jobup.ch
3. **Initialisation asynchrone** du WebView2 pour garantir que le runtime est prêt

## Compilation et Exécution

### Avec Visual Studio 2022
1. Ouvrez `WebView2App.sln`
2. Restaurez les packages NuGet (automatique)
3. Compilez le projet (F6)
4. Exécutez l'application (F5)

### Avec la ligne de commande
```bash
# Restaurer les dépendances
dotnet restore

# Compiler le projet
dotnet build

# Exécuter l'application (Windows uniquement)
dotnet run --project WebView2App/WebView2App.csproj
```

## Utilisation

1. Lancez l'application
2. Cliquez sur le bouton "Charger URL (jobup.ch)"
3. Le site web s'affichera dans le contrôle WebView2

## Notes Techniques

- Le projet cible `.NET 8.0-windows` qui est spécifique à Windows
- Le contrôle WebView2 utilise Microsoft Edge comme moteur de rendu
- L'initialisation est asynchrone pour éviter les blocages UI
- Le runtime WebView2 doit être installé sur la machine cible

## Redistribution

Pour redistribuer l'application :
1. **Option 1** : Incluez le WebView2 Runtime Bootstrapper ou Standalone Installer avec votre application
2. **Option 2** : Utilisez la version fixe du runtime embarquée avec l'application (plus volumineuse mais autonome)

Pour plus d'informations : [Guide de déploiement WebView2](https://docs.microsoft.com/microsoft-edge/webview2/concepts/distribution)
