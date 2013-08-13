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

# Wie darf ich die Software nutzen, verändern, weitergeben, ...?

Kurzform: 2qBackup steht unter der MIT-Lizenz. Weitere Informationen in LICENSE.txt.
