   M S B A M L   `   `   `  ????\  XOrganizationAthleticsCompetitions, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:OrganizationAthleticsCompetitions!OrganizationAthleticsCompetitions  5      ?    9OrganizationAthleticsCompetitions.TotalPersonalScoresPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Alocal/clr-namespace:OrganizationAthleticsCompetitions     5        N? Title$  TotalPersonalScoresPage??5	      .??5      ?  ? RowDefinitions 5   
   ?? 5      $??8* ?6   6*   ?? 5      6   .+?5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ lvTotalScore??5         
IsReadOnly .    AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6%      Header$ Название??6/   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   ?? *Name+6\     5      $ Очки??6%    63   ?? *Score+6O   5        5   
   -   5        $ lvPersonalScore??5      $y?	Collapsed=?6,    .  .   5        5      $ ФИО??6%   $ * 62    6<   ?? *
FullName+6[     5      $ Команда??6%   $ * 66    6@   ?? *	Team.Name+6`     5      $ Очки??6%    63   ?? *Score+6O   5      ?? 5   
   	 ?? Orientation$	 
Horizontal=?6   $??1??6.   $??Center=?6;   $??20q?6X   .+?5      	? -   5        $??
radioTotal??5   W   
 	? 	GroupName$
 score??6   $#??Командный зачет??6,    d? 	IsChecked$
 TrueY?6F   $
??20 0q?6i   6?   	? 5       -   5        $??radioPersonal??5    C   $
 score??6   $??Личный зачет??6,   6v   5!      5"      5#      