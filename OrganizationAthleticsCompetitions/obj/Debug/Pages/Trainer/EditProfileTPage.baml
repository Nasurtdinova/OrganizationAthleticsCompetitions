   M S B A M L   `   `   `  ????\  XOrganizationAthleticsCompetitions, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:OrganizationAthleticsCompetitions!OrganizationAthleticsCompetitions  5      8    2OrganizationAthleticsCompetitions.EditProfileTPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Alocal/clr-namespace:OrganizationAthleticsCompetitions     5        N? Title$  EditProfileTPage??5	      .??5      ?  ? ColumnDefinitions 5   
   ?? 5      6"   ?? 5      $??2* ?6   6,    ? RowDefinitions 5   
   ?? 5      $	??250 ?6   6+   ?? 5      6   ?? 5      6   ?? 5      6   ?? 5      6   ?? 5      6   .+?5   
   ?? -   5        $??btnEditPhoto??5   )   $??Добавить фото??6   $??2??6X   $??1??6l   $	??200??6y   6?   ?? 5   
   $??ФИО??6   $??2??6   6.   ?? 5   
   $??
Логин??6   $??4??6!   60   ?? 5   
   -   5        $??btnEditProfile??5   1   $/??)Редактировать профиль??6   $??2??6d   $??5??6x   $	??300??6?   6?   ?? 5   
   -   5         ??Name$ 
imgTrainer??5      $??2??6$   $	??300??68   ??5      ?? 5       ?? Path$ Image?6    ?? TargetNullValue 5      ?? 5        ?? 	UriSource$J D/OrganizationAthleticsCompetitions;component/Images/PhotoProfile.png??6&   6y   5"      5$      ?? 5%   
   -   5        $??
tbFullName??5%   Z   $??2??6   $??1??6   $	??400??6N   ??6/   ?? *User.FullName+6n   ?? 5&   
   -   5        $??tbPhone??5&   W   $??4??6   $??1??6   $	??400??6K   ??6/   ?? *
User.Login+6h   5'      5(      