# MvcMovie - Test departajare Roweb
Testul consta in parcurgerea primilor 5 pasi (get started, add controller, add view, add model, work with a database) din tutorialul urmator: https://learn.microsoft.com/ro-ro/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-6.0&tabs=visual-studio si similar cu ce e descris in tutorial adaugati elementele necesare pentru o colectie de jocuri video.

1. De adaugat paginare (vezi tutorialul de mai jos).  
Pentru a se demonstra ca s-a inteles tutorialul, paginarea NU se va face cu buton de previous & next, ci vor fi listate sub tabel toate paginile si in functie de numarul paginii selectate, vor fi aduse datele corespunzatoare.
https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/sort-filter-page?view=aspnetcore-5.0

2. De adaugat posibilitatea de a insera recenzii / review-uri.
In view-ul de detalii, imediat sub proprietatile unui movie, se va implementa un tabel cu review-urile utilizatorilor (nume utilizator, data completarii si recenzia propriu-zisa) iar sub tabel, se vor adauga 3 elemente noi pentru adaugare de review:

    - un input unde se va completa numele persoanei care face review-ul;
    - un input unde se va completa review-ul propriu-zis;
    - un buton pentru inserarea acestuia.  
    
    De indata ce se face inserarea, tabelul cu recenzii trebuie sa fie actualizat si sa afiseze si noua inregistrare inserata.
