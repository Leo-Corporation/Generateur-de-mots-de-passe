# Générateur de mots de passe
Générateur de mots de passe, comme indique son nom, ce programme sert à générer des mots de passe plus ou moins complexes.
## Branches
Il existe deux branches :
* master
* Version_Next

master est la branche de base, tandis que la branche Version_Next sert à héberger les versions instables, qui sont destinées à remplacer la version stable.

## Contribuer
Pour prendre connaissance des règles de contribution, cliquez [ici](https://github.com/Leo-Corporation/Generateur-de-mots-de-passe/blob/master/CONTRIBUTING.md).

# Version 3.0
## 1. Introduction
Générateur de mots de passe est un logiciel qui permet de générer des mots de passe simplement.
Dans un logiciel, l'interface utilisateur est un point clé : elle doit être simple à comprendre pour l'utilisateur et jolie.
Actuellement, l'interface de Générateur de mots de passe respecte certains de ces critères, mais elle n'est plus très à la page.
C'est pour cela que la version 3.0 de Générateur de mots de passe devra comporter une meilleure interface.
## 2. Guna.UI
La version 3.0 utilisera un "framework de design" qui est [Guna.UI](https://github.com/sobatdata/Guna.UI-Framework-Lib).
Guna.UI permet de designer une interface utilisateur simplement en .NET Framework.
Le framework contient de nombreux contrôles intéressants comme : 
- GunaAdvenceButton
- GunaAdvenceTileButton
- GunaDragControl
- GunaElipse
- GunaControlBox
- GunaTextBox
- GunaShadowForm
- etc...
## 3. "Cahier des charges"
Cette version 3.0 devra comporter des changements majeurs liés à l'interface.
Voici donc "To Do List" des changements à effectuer : 
- [ ] Ajouter Guna.UI (#21)
- [ ] Embellir l'interface (#22)
- [ ] Ajouter le contrôle "GunaShadowForm" (#23)
- [ ] Ajouter le contrôle "GunaElipse" (#23)
- [ ] Rendre le thème sombre compatible (#24)
- [ ] Modifier la propriété `FormBorderStyle` à `None` (#23)
- [ ] Ajouter le contrôle GunaDragControl (#23)
- [ ] Ajouter le contrôle GunaControlBox (Close & minimize)(#23)
- [ ] ...
Cette liste pourra être modifiée à tout moment.
