

--1) wypisz zawodnikow posortowanych po kraju 

select * from zawodnicy order by kraj

--2) wypisz zawodnikow posortowanych w formie 
   -- imie nazwisko kraj 

select imie + ' ' + nazwisko + ' ' + kraj
from zawodnicy
order by imie + ' ' + nazwisko + ' ' + kraj


--3) wypisz uporządkowaną listę zawodników według daty urodzenia

select *
from zawodnicy
order by data_ur

--4) wypisz liste wzszystkich zawodników posortowanych według BMI

-- bmi : waga/(wzrost/100)^2



select imie + ' ' + nazwisko + ' ' +
     format(
         ROUND(CONVERT(varchar, waga/ power( (wzrost/100.0),2) ),2) ,
        '0.00')
from zawodnicy
order by waga/ power((wzrost/100.0),2)


--5) wypisz listę zawodników posorotwanych po nazwisku
-- ale wyświetl "imie nazwisko (kraj)"

select imie + ' ' + nazwisko + 
' (' + kraj + ')'
from zawodnicy
order by nazwisko




