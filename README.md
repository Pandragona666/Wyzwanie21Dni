# Wyzwanie21Dni

Prosta aplikacja konsolowa, do wpisywania ocen książek.
Założenia:
•	Oceny można zapisywać w pamięci programu lub w osobnym pliku txt.
•	Tytuł książki nie jest case sensitive
•	Przedział ocen od 1 do 6
•	Można podawać ułamki dziesiętne, np 3,5469 (program zaokrągla je do 2 miejsc po przecinku)
•	Można podawać oceny w formacie 6-, 5+, 5- itd, które są odpowiednio knwertowane (1+ to 1.5, 2- to 1,75, 2+ to 2,5 itd)
•	Jeśli zostanie podana ocena 3 lub mniejsza, wyskakuje komunikat o niskiej ocenie.
•	Po zakończeniu dodawania ocen, wyświetlają się podsumowania statystyczne (ocena minimalna, maksymalna i średnia)
•	Jeśli zdecydujemy się na wybór zapisywania ocen w pliku, będzie on nosił nazwę po tytule wpisanej książki np „MORT.txt”. Dodatkowo, utworzy się plik „audit.txt”, do którego będą zapisywane oceny wszystkich ksiażek, wraz z datą nadania ocen.
Działanie programu:
1.	Wybrór metody zapisu ocen: 0 w pamięci, 1 – do pliku
2.	Wpisanie tytułu książki (nie jest case sensitive)
3.	Wpisanie oceny książki (aby zakończyć dodawanie ocen, należy wpisać „q”)
4.	Wyświetlenie statystyk ocenianej książki
