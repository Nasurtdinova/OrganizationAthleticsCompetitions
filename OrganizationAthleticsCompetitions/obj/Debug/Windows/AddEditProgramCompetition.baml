   M S B A M L   `   `   `  ????\  XOrganizationAthleticsCompetitions, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:OrganizationAthleticsCompetitions!OrganizationAthleticsCompetitions  5   	   A    ;OrganizationAthleticsCompetitions.AddEditProgramCompetition   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.6.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   ;local/clr-namespace:OrganizationAthleticsCompetitions  5   	     ? Title$  AddEditProgramCompetition??5	   	   $	??450??6+   $	??800??68   .??5
      ?  ? ColumnDefinitions 5   
   ?? 5      6!   ?? 5      6!    ? RowDefinitions 5   
   ?? 5      6   ?? 5      6   ?? 5      6   ?? 5      6   ?? 5      6   ?? 5      6   ?? 5      6   .+?5   
   ?? $??Тип программы??6   6+   ?? 5   
   $??Вид бега??6   $??1??6$   63   ?? 5   
   $??Дата??6   $??2??6    6/   ?? 5   
   $??
Время??6   $??3??6!   60   ?? 5   
   $>??8Максимальное число участников??6   $??4??69   6H   ?? 5   
   -   5        $??tbGender??5      $??Род??6   $??5??6/   6>   ?? 5   
   -   5         ??Name$ comboTypeProgram??5   #   $??1??6    ?? DisplayMemberPath$
 Name??6b    ?? SelectedItem 6=   ?? *TypeProgram+6}   ?? 5   
   -   5        $ comboTypeCompetition??5   0   $??1??6   $??1??6#   $
 Name??6w    6N   ?? *TypeCompetition+6?   (  "System.Windows.Controls.DatePicker  5    
   -   5        $??dpDate??5    %   $??1??6   $??2??63      SelectedDate 6@   ?? *Date+6`   )  #MaterialDesignThemes.Wpf.TimePicker  5!   
   -   5        $??tpTime??5!   $   $??25(?62      	Is24Hours .    SelectedTimeFormat$ Short=?6Q   $??1??6l   $	??250??6|   $??50??6?   $??3??6?   6?   ?? 5"   
   $??4??65   $??1??6B   ??6   ?? *MaxCountAttendees+6T   ?? 5#   
   -   5        $ comboGender??5#   0   $??1??6   $??5??6#   $
 Name??6f    6E   ?? *	Gender1+6?   ?? 5$   
   -   5        	 ??Name$	 btnSave??5$      $??Сохранить??68   $??2??6L   $??6??6`   6o   5%      5&      