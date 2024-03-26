# Time Assist
Amon Burgherr, 18.03.24
## Inhaltsverzeichnis
- Problembeschreibung
- Art und Vorgehensweise Prototyping
- Anforderungen
- Testfälle
- Testprotokoll
- Testbericht

## Problembeschreibung
Viele Leute wissen nicht wie sie sich ihre Zeit und Aufgabe einteilen sollen. Deshalb möchte ich eine Applikation erstellen, die damit hilft. In der Applikation sollen Aufgaben und freie Zeit eingetragen werden. Diese Aufgaben werden dann immer auf Freie Zeitfenster verteilt, falls solche vorhanden sind. Wenn eine Aufgabe erledigt ist, kann die tatsächliche Zeit eingetragen werden. Bei jeder neuen Aufgabe und der dazugehörigen schätzung wird dann die durchschnittliche Abweichung der Schätzungen als Prozentsatz errechnet. Mit diesem Prozentsatz wird dann ein alternativ Vorschlag für die Zeit Einschätzung errechnet und gegeben. Der kann angenommen oder verworfen werden.

## Anforderungen
 Anforderung Nr. | Anforderung | Typ
-------- | -------- | --------
 1 | Neue Aufgabe mit geschätzter Zeit erstellen und in DB speichern.   | Funktional
 2 | Freies Zeitfenster eintragen und in DB speichern.   | Funktional
 3 | Tatsächliche Zeit einer erledigten Aufgabe eintragen und in DB speichern   | Funktional
 4 | Mit gespeicherten Daten (Aufgaben, Freie Zeit...) Vorschläge für die Zeitplanung generieren. | Funktional

## Testfälle
Anforderung Nr. | Testfälle Nr. | Vorraussetzung | Input | Output
-------- | -------- | --------|-------- | --------
1, 4 | 1.1 | Programm gestartet | Aufgabe und geschätzte Zeit | [Aufgabe] wurde am [Zeitpunkt] eingeteilt / keine Freie Zeit vorhanden
2 | 2.1 | Programm gestartet | Freie Zeitfenster eintragen | Anzeige im Wochenplan
3 | 3.1 | Aufgabe vorhanden und erledigt | tatsächliche Zeit | du hattest für [Aufgabe] [Zeitdifferenz] min. mehr/weniger als geplant.
4 | 4.1 | Tatsächliche Zeit vorheriger Aufgaben eingetragen | Neue Aufgabe | Du lagst durchschnittlich mit deiner Schätzung X % daneben, möchtest du diese Schätzung auf Y Minuten anpassen

## Art und Vorgehensweise Prototyping
Es Soll ein Funktionsprototyp erstellt werden, da ich herausfinden möchte, ob die Funktionen nach meinen Wünschen umsetzbar sind.
Ich werde nach dem evolutionären Prototyping vorgehen. So kann ich die Akzeptanz der Grundfunktionen überprüfen und werde sehen wie sinvoll oder erwünscht die geplanten Nebenfunktionen sind.

# Testdokumentation
Anforderung und Testfälle siehe oben.
Testumgebung: Windows 11 PC mit nötiger Applikation und Datenbank.

## Testprotokoll

Testfälle Nr. | Resultat | Datum | Tester 
-------- | -------- | --------|-------- 
1.1 | OK | 25.03.2024 | Amon Burgherr 
2.1 | Wochenplan ist nur eine Tabelle, reicht aber für Funktion | 25.03.2024 | Amon Burgherr 
3.1 | OK | 25.03.2024 | Amon Burgherr 
4.1 | OK | 25.03.2024 | Amon Burgherr

## Testbericht
Der Prototyp erreicht die vorgegeben Anforderungen und zeigt damit genau auf was er soll. Für ein fertiges Produkt reicht es offensichtlich nicht, da es nur ein Prototyp sein sollte.
