   M S B A M L   `   `   `  ????\  XOrganizationAthleticsCompetitions, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:OrganizationAthleticsCompetitions!OrganizationAthleticsCompetitions  5      7    1OrganizationAthleticsCompetitions.AddResultWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Alocal/clr-namespace:OrganizationAthleticsCompetitions     5      $	??450??5      $
??1000??6     ? Title$1  +Добавление результатов??5	      .??5
      ?  ? RowDefinitions 5   
   ?? 5      6   ?? 5      6   ?? 5      6   ?? 5      6    ? ColumnDefinitions 5   
   ?? 5      $	??400 ?6   6-   ?? 5      6!   .+?5   
   ??  ?? Orientation$ 
Horizontal=?6   $??2??6.   $??Center=?6B   .+?5      ?? -   5         ??Name$ competitionName??5      63   ?? 5      -   5        $ typeProgram??5      $??10q?6-   6;   ?? 5      -   5        $ typeCompetition??5      63   5      ?? 5   
   $??Спортсмен??6   $??1??6%   64   ?? 5   
   $??Результат??6   $??2??6%   64   ?? 5   
   -   5        $??cbSportsman??5      $??1??6&   $	??400??6V    ?? DisplayMemberPath$ FullName??6b   $??1??6    ?? SelectedItem 63   ?? *	Sportsman+6?   ?? 5   
   $ 
Horizontal=?6   $??Center=?6.   $??2??6K   $??1??6X   .+?5      ?? -   5        $??tbResult??5   #   $	??200??6   $??20q?63   6A   ?? 5      -   5        $ formatResult??5      60   5       ?? 5!   
   -   5        $??btnAdd??5!   Q   $??Добавить??6   $??2??6$   $??3??68   $	??200??6E   6v   5"      5#      