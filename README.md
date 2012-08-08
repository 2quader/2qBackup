# 2qBackup - Was ist das?

2qBackup ist ein kleines Backup-Programm. Du gibst ihm den Pfad zu einem Verzeichnis auf deiner Festplatte und eine FTP-Adresse, und 2qBackup zippt das Verzeichnis, benennt das Archiv mit einem Zeitstempel und l�dt es auf den FTP-Server hoch.

# Wie muss die Konfigurationsdatei aussehen?

Die Konfigurationsdatei hei�t `conf.ini` und muss im selben Verzeichnis wie 2qBackup.exe liegen. So k�nnte die Datei aussehen:

```ini
[Path]
Src = C:\Temp
Tar = ftp://192.168.178.208/usb/Backup/

[Credentials]
User = backup
Pass = backup
```

# Wie darf ich die Software nutzen, ver�ndern, weitergeben, ...?

Du bekommst diesen Code kostenlos und darfst mit ihm machen was du willst, du bekommst jedoch keine Garantie auf Sicherheit, Fuktionalit�t oder sonst irgendwas.
Sollte mein Code die Welt untergehen lassen oder sonstige Sch�den (auch im kleineren Ma�e) anrichten, sag' nicht, ich w�re Schuld, denn ich habe dich gewarnt.

Es ist ratsam, diese oder eine entsprechend angepasste README-Datei mit dem Code weiterzugeben, aber ich werde dich nicht dazu zwingen.