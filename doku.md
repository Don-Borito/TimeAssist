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
1, 4 | 1.1 | Programm gestartet | Aufgabe und geschätzte Zeit | möchtest du [Aufgabe] zu [Zeitpunkt] erledigen / keine Freie Zeit vorhanden
2 | 2.1 | Programm gestartet | Freie Zeitfenster eintragen | Anzeige im Wochenplan
3 | 3.1 | Aufgabe vorhanden und erledigt | tatsächliche Zeit | du hattest für [Aufgabe] [Zeitdifferenz] min. mehr/weniger als geplant.
4 | 4.1 | Tatsächliche Zeit eingetragen | Neue Aufgabe | Du lagst durchschnittlich mit deiner Schätzung X % daneben, möchtest du diese Schätzung auf Y Minuten anpassen
