# Platforma zakładów bukmacherskich
Platforma zakładów bukmacherskich na wyścigi konne

Celem projektu jest stworzenie platformy, która umożliwiałby dokonywania przez użytkownika zakładów na symulowane wyścigi konne. Projekt ten będzie się składał z 3 elementów:

* Klienta opartego o Angular’a,

* Aplikacji platformy ASP.NET Core obsługującym usługi http RESTful oraz kontrolery platfory ASP.NET,

* Bazy danych opartej o MySql.

## Klient

Klient będzie dostarczał następujące funkcjonalności:

        * logowanie się do serwisu przez użytkownika,

        * graficznej prezentacji listy nadchodzących wyścigów,
        
        * utworzenie zakładu,

        * wyświetlanie stanu konta oraz historii zakładów,

        * dla kont o uprawnieniach administratorskich możliwość planowania kolejnych wyścigów.


## Aplikacja WebApi

Aplikacja WebApi będzie odpowiedzialna za następujące funkcjonalności:

       * autoryzacja użytkownika

       * pośredniczenie w komunikacji pomiędzy użytkownikiem a bazą danych,

       * wykonywanie obliczeń i zapisywanie ich wyniku w bazie danych,

       * symulacje wyścigów.

## Baza danych

Zadaniem bazy danej będzie przechowywanie następujących informacji:

        * danych do autoryzacji,

        * danych klienta,

        * danych o dostępnych koniach.

        * danych o przebiegu wyścigu dla wybranego konia,

        * danych o wyscigu
        



### Diagram PDM:

![Diagram ERD](https://raw.githubusercontent.com/gilotyna1808/TIU_Projekt/main/Diagram_ERD.png)
