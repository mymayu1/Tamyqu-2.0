![Unity: 2021.2](https://img.shields.io/badge/unity-2021.2-ff6964)

# TAMYQU 2.0 - 3D Game

## Beschreibung
Bei unserem 3D Spiel handelt es sich um einen Third Person Shooter Spiel, wobei der Player innerhalb 60 Sekunden soviele Punkte wie möglich sammeln soll. Dabei muss der Player Meteoriten ausweichen und soviele Zombies wie möglich töten.


## Genre & Artstyle
Highscore Game, Third Person Shooter auf einem Globus


## Features

### Player 
Der Player wird mit den WASD- oder mit den Pfeiltasten vorwärts, rückwärts und rotierend gesteuert. Mit SPACE springt der Player und mit Rechtsklick auf der Maus oder der N-Taste schießt er einen Schuss.
Während des Spiels kann der Player mit der P-Taste pausieren.


### Enemies
#### 1. Zombies
Es werden 20 Zombies auf dem Globus platziert, wobei zehn Zombies sich Random fortbewegen, und die anderen 10 Zombies dem Player folgen und angreifen.
Kommt der Player in Berührung mit dem Zombie, wird dem Player Lebenspunkte und Sammelpunkte abgezogen.
Die Zombies haben nur drei Leben.

#### 2. Meteoriten
Es werden während des Spiels Meteoriten zufällig auf dem Globus fallen. 
Kommt der Player in Berührung mit den Meteoriten, wird dem Player auch Lebenspunkte und Sammelpunkte abgezogen.

#### 3. Feuer
Im Spiel wurden mehrere Lagerfeuer platziert, die schädlich für den Player sind. Auch dabei bekommt der Player Schaden.

### Items
Im Spiel wurden drei Items (Potions) platziert, womit der Player seine Lebenspunkte aufladen kann.


## Spiel

### Hauptmenü & Pausenmenü
Zu Beginn des Spiels wird das Hauptmenü angezeigt mit zwei Optionen, einmal dem Play-Knopf um das Spiel zu starten und dem Quit -Knopf um das Spiel zu beenden.

![ezgif com-gif-maker](https://user-images.githubusercontent.com/65132134/153276877-b9bc76a4-8cd6-4a66-9812-5a7941e92e36.gif)


Das Pausenmenü wird durch die P Taste aufgerufen.


![Hauptmenu](https://user-images.githubusercontent.com/65132134/153279185-ee303376-2102-4039-95f0-ab57dbf90e2a.gif)


### Player Control

Steuerung des Players
- Rennen und Springen

![Shoot andJump](https://user-images.githubusercontent.com/65132134/153283228-20bcc70e-3618-487e-931a-880739096858.gif)

- Schießen

![Shoot Zombie](https://user-images.githubusercontent.com/65132134/153283539-a120b4b1-b9ab-49ff-b077-13706e024b1b.gif)

### Items

- Potion füllt die Gesundheit des Players etwas auf

![collect potion](https://user-images.githubusercontent.com/65132134/153283458-618c7d31-d6cc-41f4-81bc-adb9e08f679e.gif)


### Enemies

- Zombieangriff. Vorsicht!

![ZombieAttack](https://user-images.githubusercontent.com/65132134/153283472-75318528-2c37-400a-8e3d-379d2b5e5955.gif)

## Punktesammlung

Bei einem Schuß auf dem Zombie bekommt man 5 Punkte, beim töten 10 Punkte.
Wird man aber von einem Zombie angegriffen, werden 5 Punkte abgezogen.
Berührt man einen Meteorit werden auch 5 Punkte abgezogen.


Ziel ist es soviele Punkte wie möglich innerhalb von 60 Sekunden zu erreichen.

#### Das Spiel ist vorbei, wenn die Zeit abläuft oder kein Leben mehr übrig ist.

### Team
Tanem Basaraner, Tra My Nguyen, Quynh Vi Trinh

### Built With
Software
* Unity Version 2021.2.6f1
