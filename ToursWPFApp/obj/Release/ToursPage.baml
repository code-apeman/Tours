   M S B A M L   `   `   `  ����   ToursWPFApp    ToursWPFApp.ToursPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008       N� Title$  Туры��.���  � RowDefinitions �� $
��auto ��� $��* �.+��  � Orientation$ 
Horizontal=�$��Center=�.+���  �� Orientation$ 
Horizontal=�.+��� $:��4Введите название для поиска:��$	��175�� �� TextAlignment$ Right=��� -   $��tbSearch��$	��225���� $ 
Horizontal=�.+��� $��Выберите тип:��$	��175��$ Right=��� -   $��cbType��$	��225�� �� DisplayMemberPath$
 Name���� -    ��Name$ cbAvailable��$'��!Только актуальные��$��Center=�$��Center=��� -    ��Name$ lvTours��$��1��$��Disabled=�$��Center=����� .R�� $ 
Horizontal=�$��Center=����� .R�� $��20q�$	��400�� �� $��70 ��� $	��310 ��� $
��auto ��� $
��auto �.+��� $	��400��$��1��$��Center=�$��5q����� *ImageStretch+����  �� Path$ ImagePreview�	 �� TargetNullValue	 ��#Resources/placeholder-image.png���� $��Center=�$ Center=�$	��390��$
��Wrap=�$��Center=�$	��5 5q�$��26(�$��0������ *Name+�� $��2��$��5 5 5 15q�$��Center=�$��26(�$
��Bold"����� *Price+
 �� StringFormat$
 
{0:N2} ₽���� $��3��$��14(�$��Right=����� *TicketCount+$*
 $Билетов осталось: {0}���� $��3��$��14(�$
��Left=����� *AvailabilityText+