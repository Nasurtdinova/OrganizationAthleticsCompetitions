   M S B A M L   `   `   `  ????\  XOrganizationAthleticsCompetitions, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:OrganizationAthleticsCompetitions!OrganizationAthleticsCompetitions  5      >    8OrganizationAthleticsCompetitions.ResultCompetitionsPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Alocal/clr-namespace:OrganizationAthleticsCompetitions     5      _ [MaterialDesignThemes.Wpf, Version=4.6.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N? Title$  ResultCompetitionsPage??5
      .??5      ?  ? ColumnDefinitions 5   
   ?? 5      6"   ?? 5      $	??480 ?6   6-    ? RowDefinitions 5   
   ?? 5      6   ?? 5      $??8* ?6   6*   ?? 5      6   .+?5   
   ??  ?? Orientation$ 
Horizontal=?6   $??2??6.   .+?5      ?? $/??)Выберите соревнование??6   $??10q?65   6C   ?? 5      -   5        $??comboCompetitions??5      $	??400??60    ?? DisplayMemberPath$
 Name??6<   6?   5      ?? 5   
   -   5         ??Name$ btnLoadExcel??5      $y?	Collapsed=?6B   $#??Загрузить из Excel??6Y   $	??200??6v   $??1??6?   6?   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgRrogramsCompetitions??5   N   $??1??6      
IsReadOnly .    AutoGenerateColumns .  	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Программа??6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 68   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6B   ?? *TypeProgram.Name+6i     5      $
 Вид??6%    62   ?? *TypeCompetition.Name+6]     5      $
 Дата??6%    63   ?? *Date+ ?? StringFormat$ 
dd.MM.yyyy??6i     5       $
 
Время??6%    64   ?? *	TimeStart+$ hh\:mm??6i     5!      $
 Род??6%    62   ?? *Gender+6O   5#        5$   
   -   5        $ dgResulsPrograms??5$   ?   $??1??6   $??1??6    $??Visible=?60    .  .  	 5%        5&      $
 ФИО??6%   $ * 62    6<   ?? *Request.Sportsman.FullName+6m     5'      $
 
Место??6%    64   ?? *Rank+6O   4  .System.Windows.Controls.DataGridTemplateColumn  5(      $ 0 6)   -   5        removeColumn??   CellTemplate 5)      ?? 5*      .R?5+      ?? $ btnRemoveResult??6%   -   5        $??30??5+   >   .??5,   "   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Remove=?6:   5-      5.      50      52      ?? 53   
   $ 
Horizontal=?6   $??2??6.   $??2??6;   $??Center=?6O   $??Center=?6l   .+?54      ?? -   5        $ btnBack??54      $??
Назад??6&   $	??150??66   6Z   ?? 55      -   5        $ btnAddResult??55      $??10q?6+   $??Добавить??67   $y?	Collapsed=?6e   6~   56      57      58      