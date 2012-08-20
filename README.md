# 2qBackup - Was ist das?

2qBackup ist ein kleines Backup-Programm. Du gibst ihm den Pfad zu einem Verzeichnis auf deiner Festplatte und eine FTP-Adresse, und 2qBackup zippt das Verzeichnis, benennt das Archiv mit einem Zeitstempel und lädt es auf den FTP-Server hoch.

# Wie muss die Konfigurationsdatei aussehen?

Die Konfigurationsdatei heißt `conf.ini` und muss im selben Verzeichnis wie 2qBackup.exe liegen. So könnte die Datei aussehen:

```ini
[Path]
Src = C:\Temp
Tar = ftp://192.168.178.208/usb/Backup/

[Credentials]
User = backup
Pass = backup
```

# Screenshots

Screenshot 1: Das Programmfenster vor dem Start des Backups

![Screenshot 1](https://github.com/downloads/2quader/2qBackup/screenshot_1.png)

Screenshot 2: Das Programmfenster nach dem Backup

![Screenshot 2](https://github.com/downloads/2quader/2qBackup/screenshot_2.png)

# Wie darf ich die Software nutzen, verändern, weitergeben, ...?

Du bekommst diesen Code kostenlos und darfst mit ihm machen was du willst, du bekommst jedoch keine Garantie auf Sicherheit, Fuktionalität oder sonst irgendwas.
Sollte mein Code die Welt untergehen lassen oder sonstige Schäden (auch im kleineren Maße) anrichten, sag' nicht, ich wäre Schuld, denn ich habe dich gewarnt.

Es ist ratsam, diese oder eine entsprechend angepasste README-Datei mit dem Code weiterzugeben, aber ich werde dich nicht dazu zwingen.