# Projet_Dev : Pixel Fighters
*Par Lucas MILH et Antonin Jouannet*

---

## Présentation du Projet
Bienvenue dans notre projet dev de 2eme année, **Pixel Fighters**.

A l'origine, il s'agissait d'un projet ambitieux : créer un jeu de combat à partir de 0. Ce projet était bien trop ambitieux, et nous avons très vite regretté notre choix. 

Le développement d'un jeu de combat complet est une tâche complexe, d'autant plus lorsqu'aucun des deux membres n'a déjà utilisé Unity, et que l'un n'a pas pu utiliser ce moteur pendant un bon moment. N'ayant au début du projet aucune compétence en matière de développement de Jeux-Vidéos, nous avons mis un bon moment avant de prendre en main Unity, ainsi que les différentes logiques derrière le fonctionnement d'un jeu (Layers, Vecteurs, Animation/Animator etc). 

Même si le projet est un échec, étant donné que nous n'avons pas réussi à créer quelque chose de réellement concret, laissez-nous vous parler de ce que nous avons réalisé, et des problèmes que nous avons rencontré.

---
## Features du projet 

### 1) Ryu_Script
Ryu est notre personnage jouable. Grace à Anthony, qui nous a passé l'image contenant chaque sprite du personnage, nous avons pu retranscrire les différentes animations et déplacements du personnage. Il y a actuellement : Déplacement latéral, attaque, saut, s'accroupir, animation d'idle.

Les différents paramètres nécessaires aux actions du personnages sont recensés dans le script ```/Assets/Ryu_script.cs```. 

### 2) CollideBox, RigidBody et Gestion du sol

Après la création du personnage, il fallait faire en sorte qu'il puisse se déplacer sur un sol fixe, et qu'il ne tombe pas dans le vide. Pour cela, nous avons simplement utilisé Unity, qui permet de créer un RigidBody pour appliquer de la gravité à un objet. Nous avons appliqué cette propriété à notre GameObject Ryu, et avons ensuite utilisé un Box Collider 2D sur des plateformes, situées de chaque côtés de la carte, afin que Ryu ne puisse sortir des limites.

## Problèmes rencontrés

Nous avons vu les features qui ont été mises en place, parlons maintenant des problèmes que nous avons rencontrés pour les autres.

Dans les derniers jours du projet, je me suis concentré sur les changements de Scenes, afin de créer un menu, et pouvoir rediriger dans le scène de combat si le joueur appuie sur un bouton. Malheureusement, au moment d'importer le script dans un gameObject, Unity crashait. Nous avons eu beau chercher, nous n'avons rien trouvé nous permettant de régler cela. De plus, on s'est rendu compte aujourd'hui qu'il s'agissait d'un problème de licence, et non de code. Vous pourre trouver le code de changement de scène dans ```/Assets/BtnClicker.cs```, même si celui-ci n'a pas pu être directement lié au projet. 

Notre gestion du temps a été catastrophique sur le projet. Perdu dans un projet beaucoup trop gros pour nous, sans ligne directive claire, et étouffé par les autres projets que nous avions à faire, nous n'avons pas réussi à nous organiser convenablement, ce qui nous emmene à ce résultat décevant. 

## Conclusion

Ce projet, bien que raté, nous aura appris pas mal de choses. Il faut parfois savoir voir petit, et aggrandir au fur et à mesure, apprendre à s'organiser autour d'une ligne conductrice. Malgré tout, nous avons appris pas mal de choses concernant le développement de jeux vidéos, ce qui va me permettre d'approcher plus facilement la suite de mes études en Jeux-Vidéos.




Lucas Milh et Antonin Jouannet

