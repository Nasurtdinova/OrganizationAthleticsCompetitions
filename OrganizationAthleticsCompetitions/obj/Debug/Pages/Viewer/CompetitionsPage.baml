   M S B A M L   `   `   `  ????\  XOrganizationAthleticsCompetitions, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:OrganizationAthleticsCompetitions!OrganizationAthleticsCompetitions  5      8    2OrganizationAthleticsCompetitions.CompetitionsPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Alocal/clr-namespace:OrganizationAthleticsCompetitions     5      _ [MaterialDesignThemes.Wpf, Version=4.6.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N? Title$  CompetitionsPage??5
      .??5      ?  ? RowDefinitions 5   
   ?? 5      $??50 ?6   5      ?? 5      $??50 ?6   5      ?? 5      5      ?? 5      $??50 ?6   5      .+?5   
   ?? $??1??6    ?? Orientation$ 
Horizontal=?6"   .+?5      ?? $??25??6   $??40??6    $d??^C:\Users\nasur\Source\Repos\Final_Project_ASP_MVC_Clone\RunningCompetitionWPF\Icons\search.png??6+   6?   ?? 5      -   5        $??	txtSearch??5   I   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Найти??6   $	??180??6=   $??40??6   ?? 5      -   5        $??
checkMonth??5      $??Текущий месяц??6)   $??Right=?6A    d? 	IsChecked$ FalseY?6]   $??10q?6?   6?   ?? 5      $??30??6   $??40??6    $b??\C:\Users\nasur\Source\Repos\Final_Project_ASP_MVC_Clone\RunningCompetitionWPF\Icons\city.png??6+   6?   ?? 5      -   5        $??	comboCity??5       ?? DisplayMemberPath$
 Name??6(   $	??200??6A   $??30??6M   6?   5      ?? 5   
   $??Соревнования??6   $??23(?6(   68   ?? 5   
   $??2??6   .@?5      ?? $??Предстоящие??6   ??5       &   System.Windows.Controls.DataGrid  5!      -   5          Name$ dgFutureCompetitions??5!   m    ?? AlternationCount$ 2??6   $??18(?6?      AutoGenerateColumns .  	   
IsReadOnly	 . 
   Columns
 5"      0  *System.Windows.Controls.DataGridTextColumn  5#      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 61      Header$ Название??6;   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6M   ?? *Name+6h     5$      $ Дата начала??61    6F   ?? *	DateStart+ ?? StringFormat$ 
dd.MM.yyyy??6?     5%      $ Дата конца??61    6E   ?? *	DateEnd+$ 
dd.MM.yyyy??6     5&      $ 
Город??61    6@   ?? *Venue.City.Name+6f     5'      $% Место проведения??61    6K   ?? *
Venue.Name+6l     5(      $ Категория??61    6D   ?? *CategoryCompetition.Name+6s   4  .System.Windows.Controls.DataGridTemplateColumn  5)         CellTemplate 5*   "   ?? 5+   &   .R?5,   *   ?? $??
btnProgram??61   -   5        $??40??5,   C   .??5-   .   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Invoice=?6F   5.   +   5/   '   51      53      55      ?? 56      $??Прошедшие??6   .??57        -   5        $ dgPastCompetitions??57   e   $ 2??6   $??Visible=?60   $??18(?6?    .  	 . 
 58        59      $ Название??6-    6?   ?? *Name+6Z     5:      $ Дата начала??6-    6B   ?? *	DateStart+$ 
dd.MM.yyyy??6~     5;      $ Дата конца??6-    6A   ?? *	DateEnd+$ 
dd.MM.yyyy??6{     5<      $ 
Город??6-    6<   ?? *Venue.City.Name+6b     5=      $% Место проведения??6-    6G   ?? *
Venue.Name+6h     5>      $ Категория??6-    6@   ?? *CategoryCompetition.Name+6o     5?       5@      ?? 5A   "   .R?5B   &   ?? $??	btnResult??68   -   5        $??40??5B   -   .??5C   *     $ Invoice=?6B   5D   '   5E   #   5G      5I      5J      5K      ?? 5L   
   $ 
Horizontal=?6   $??3??6.   $??Center=?6;   .+?5M      ?? -   5         ??Name$ btnBack??5M      $??
Назад??6&   $??10q?6L   6Z   ?? 5N      -	   5        $ btnAddCompet??5N      $??Добавить??6+   $y?	Collapsed=?6>   6r   5O      5P      5Q      