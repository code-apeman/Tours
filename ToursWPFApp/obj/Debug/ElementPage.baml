   M S B A M L   `   `   `  ����F  BToursWPFApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:ToursWPFAppToursWPFApp  5          ToursWPFApp.ElementPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:ToursWPFApp     5        N� Title$  ElementPage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��Название��6   $��0��6$   �� 5   
   $%��Количество звёзд��6   $��1��6,   �� 5   
   $��Страна��6   $��2��6"   �� 5   
   -   5         ��Name$ tbName��5   8    �� 	MaxLength$	 255��6(   $��1��6H   $��0��6X   ��6   �� *Name+6X   �� 5   
   -   5        $ tbStarCount��5   -   $��1��6B   $��1��6R   ��6   �� *	StarCount+6�   �� 5   
   -   5         ��Name$ cbCountries��5   4   $��1��6I   $��2��6Y    �� DisplayMemberPath$
 Name��6f    �� SelectedItem 6   �� *	Country+6f   �� 5   
   -   5        $��bSave��5   F   $��Сохранить��6   $��2��6%   $��3��69   6S   5      5      