#Livrables
Les étudiants devront livrer avant le 31 décembre 23 :59 leur projet par mail à l’adresse zipper@free.fr .

Le mail devra impérativement comporter comme sujet : Ing5-ECE-2014-<NomEtudiant1> <NomEtudiant2>, Remplacer les balises <NomEtudiant> par le nom des étudiants formant le binôme. Si des patronymes existent rajouter à la fin du nom la première lettre du prénom.

Le mail devra contenir 2 pièces jointes :

* Le dossier contenant la solution ainsi que l’ensemble des codes sources. Il est conseillé de compresser l’ensemble du répertoire et d’en modifier l’extension (.zip en .piz) afin d’éviter les blocages par l’antivirus. Le dossier devra avoir le nom Projet-<NomEtudiant1> <NomEtudiant2>.

* La seconde pièce jointe sera un rapport de 2-3 pages indiquant les points forts de votre projet, les méthodes ayant une forte valeur ajoutées, les bugs identifiés, ainsi qu’une procédure d’installation si nécessaire. Ce document devra avoir le nom Rapport-<NomEtudiant1> <NomEtudiant2>

#Réalisation demandé.
#Développement serveur.
Les étudiants devront reprendre le code réalisé lors des différentes séances de TP, par défaut ils partiront sur le projet mis-en-ligne sur le site du cours.

Il est demandé d’ajouter au contrat de service 2 méthodes permettant la recherche de bagages :
List<Bagage>BagRecherche(string CodeCie, string ligne, datetime Date, string PatternCodeBag)qui permet de retrouver tous les bagages à la date spécifiée dont le patternCodeBag correspond au code IATA du bagage, CodeCie au code IATA de la compagnie et ligne au numéro de vol, chacun de ces champs de recherche étant optionnel.

List<Bagage>BagRecherche(int idVol) qui permet la récupération de l’ensemble des bagages d’un vol à une date définie.

Que le service implémente 1 ou 2 méthodes et qu’il utilise 1 ou 2 méthodes dans le modèle de données importe peut, c’est bien au niveau du contrat que ces méthodes doivent être visibles.

D’une méthode permettant l’affichage détaillé d’un bagage et de sa traçabilité, dont seuls les utilisateurs appartenant au groupe CDG1 auront accès à la fiche bagage mais sans la traçabilité, seuls les utilisateurs du groupe CEBCDG1 auront accès à la traçabilité. Cette méthode doit renvoyer une exception fortement typée à l’utilisateur si l’IdBagage n’est pas trouvé par le service.
Bagage BagDetail(int idBagage)

Le service devra mettre en place un mécanisme afin de contrôler les demandes invalides, inscription en base de données ou génération d’un fichier de logs. Chaque ligne devra contenir la date et l’heure de la demande, le nom de la méthode demande et si l’information est disponible le nom de l’utilisateur ayant fait la demande.

##Développement client.
###Page Principale.

La page principale de l’application cliente sera constituée de 3 boutons permettant l’accès aux différentes sections de l’application, à savoir Paramétrage, Recherche Vol et Recherche Bagage.

###Section paramètres.

La section paramétrage doit permettre à l’utilisateur de passer dans un mode identifié (Windows ou UserName). A défaut d’information d’identification, la connexion au service se fera anonymement. Idéalement l’utilisateur doit pouvoir se connecter et se déconnecter sans qu’il soit nécessaire de redémarrer le client.

Si plusieurs points de terminaisons sont à la disposition de l’utilisateur, le choix sera paramétrable dans cette section.

D’une manière générale seront regroupés ici tous les éléments configurables accessibles à l’utilisateur.

###Section Vol.

Cette section présente une page de recherche de vols, avec un certain nombre de paramètres de recherche, qui retourne une description succincte des vols correspondant au filtre.

Chaque item vol listé par la recherche permet d’accéder à la fiche détaillé de celui-ci.

Ces éléments ayant servi de fils rouge lors des différentes séances de TP les étudiants n’auront pas à y revenir, même si tout n’est pas implémenté et fonctionnel. Seul l’ajout d’un lien entre un vol présent dans le résultat de la recherche avec le détail d’un bagage peut être ajouté.

###Section Bagage.

Cette section présente une page de recherche de bagages en fonction des critères mis à dispositions par le service à savoir : Le code compagnie, le numéro de ligne du vol, la date du vol ou du bagage, et un template de code Iata du bagage. Si la liaison entre le résultat de recherche de la section vols et le détail d’un bagage n’est pas implémenté, il sera nécessaire de rajouter une zone de saisie pour l’id_vol. Si une information est saisie dans cette zone alors toutes autres informations de filtrage seront ignorées.

####Requête SQL pour recherche bagage

```
select b.id_bsm, b.code_iata, b.ligee, b.typ, b.recol, b.emb, b.dat_cre, b.cnt, b.id_vol

from bsm b

where ....

```

