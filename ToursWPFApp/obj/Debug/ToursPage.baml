   M S B A M L   `   `   `  ����  ToursWPFApp    ToursWPFApp.ToursPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        N� Title$  Туры��5      .��5
      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �  � Orientation$ 
Horizontal=�6   $��Center=�6-   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $:��4Введите название для поиска:��6   $	��175��6@    �� TextAlignment$ Right=�6L   �� 5      -   5        $��tbSearch��5   &   $	��225��6   66   5      �� 5      $ 
Horizontal=�6   .+�5      �� $��Выберите тип:��6   $	��175��61   $ Right=�6=   �� 5      -   5        $��cbType��5   '   $	��225��6    �� DisplayMemberPath$
 Name��6`   5      �� 5      -   5         ��Name$ cbAvailable��5      $'��!Только актуальные��6j   $��Center=�6�   $��Center=�6�   5      �� 5   
   -   5         ��Name$ lvTours��5      $��1��6$   $��Disabled=�61   $��Center=�6g   ��5      �� 5      .R�5      � $ 
Horizontal=�6    $��Center=�69   5       ��5"      �� 5#      .R�5$      � $��20q�6   $	��400��6'    5%      �� 5&      $��70 �6,   �� 5'      $	��310 �6,   �� 5(      $
��auto �6,   �� 5)      $
��auto �6,   .+�5+      �� $	��400��6    $��1��6,   $��Center=�6Z   $��5q�6w   ��69   �� *ImageStretch+��5,      �� 5-   "    �� Path$ ImagePreview�6*   	 �� TargetNullValue	 5.   &   ��5/   *   #Resources/placeholder-image.png��6W   51   #   53      �� 54      $��Center=�6:   $ Center=�6U   $	��390��6l   $
��Wrap=�6x   $��Center=�6�   $	��5 5q�6�   $��26(�6�   $��0��6�   ��6$   �� *Name+6�   �� 55      $��2��6T   $��5 5 5 15q�6a   $��Center=�6s   $��26(�6�   $
��Bold"�6�   ��6$   �� *Price+
 �� StringFormat$
 
{0:N2} ₽��6�   �� 56      $��3��6g   $��14(�6t   $��Right=�6�   ��6$   �� *TicketCount+$*
 $Билетов осталось: {0}��6�   �� 57      $��3��6F   $��14(�6S   $
��Left=�6a   ��6$   �� *AvailabilityText+6a   58      59      5;      5<      5=      