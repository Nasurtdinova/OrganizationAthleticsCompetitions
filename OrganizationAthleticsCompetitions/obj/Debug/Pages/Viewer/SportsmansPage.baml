   M S B A M L   `   `   `  ????\  XOrganizationAthleticsCompetitions, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:OrganizationAthleticsCompetitions!OrganizationAthleticsCompetitions  5      6    0OrganizationAthleticsCompetitions.SportsmansPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Alocal/clr-namespace:OrganizationAthleticsCompetitions     5        N? Title$  SportsmansPage??5	      .??5
      ?  ? RowDefinitions 5   
   ?? 5      6   ?? 5      $??8* ?6   6*   ?? 5      6   .+?5   
   ?? $??Спортсмены??6   $??25(?6&   66   ?? 5   
   -   5         ??Name$ sportsmansList??5      $??1??6+   ??5      ?? 5      .R?5      A?  A? Columns$ 3??6"   $
??1100??6.   6=   5       ? 	Resources 5         DefaultItemTemplate ?? Path ?? TargetNullValue ?? 	UriSource  SelectedItemTemplate ?? Orientation	 ?? StringFormat??%?  &	        &	 7    ?? 5      .R?5      ?? .+?5      ?? $	??400??6    $	??220??6,   ??5      ?? 5   "   $ Image?6*    5   &   ?? 5   *   $J D/OrganizationAthleticsCompetitions;component/Images/PhotoProfile.png??66   6?   5    #   5"      ?? 5#      ??6$   ?? *
FullName+5$      5%      ?? 5&      .R?5'      ?? $
??Auto=?6#   $??Disabled=?6H   .??5(      ?? .+?5)      ?? $ 
Horizontal=?6)   .+?5*   "   ?? $??Команда: ??6,   ?? 5+   "   ??6,   ?? *	Team.Name+5,      ?? 5-      $ 
Horizontal=?6)   .+?5.   "   ?? ??5/   &   ?? 50   *   $ CategorySportsman.Name?62    51   .   ?? 52   2   $??Нет звания??6<   6P   54   +   56   #   57      ?? 58      $ 
Horizontal=?6)   .+?59   "   ?? $!??Дата рождения: ??6,   ?? 5:   "   ??6,   ?? *DateOfBirth+$	 
dd.MM.yyyy??5;      ?? 5<      $ 
Horizontal=?6)   .+?5=   "   ?? $??
Рост: ??6,   ?? 5>   "   ??6,   ?? *Height+5?      ?? 5@      $ 
Horizontal=?6)   .+?5A   "   ?? $??Вес: ??6,   ?? 5B   "   ??6,   ?? *Weight+5C      5D      5E      5F      5G      ??5H      ?? 5I      
 ?? 
TargetType"
 ??6   .?5J      ??  ?? Property ? ?? ?? Value# [  68    ?? Triggers 5K      P? 5L       P? Property ?@??
IsSelected P? Value . . ?5M      ??  ? ??# [ 6@   5N      5P      5R      ?? 5S   
   -   5        $??btnBack??5S   P   $??
Назад??6   $??10q?6!   $??2??6C   6a   5T      5U      