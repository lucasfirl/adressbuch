   M S B A M L   `   `   `  ����E  AAdressbuch, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Adressbuch
Adressbuch  5   	       Adressbuch.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Adressbuch     5   	   -   5          �Name$  window��5   	    � Title$ 
Adressbuch��5   	   $	��450��6   $	��600��6)   $	��600��65   $	��450��6D    � Icon$ icon.png��6T   .��5	      � $	��592��6   $	��419��6    � ColumnDefinitions 5
   
   �� 5      .+�5   
   �� -   5         ��Name$ textName��5      $��19��6$   $��93,22,187,0q�60    �� TextWrapping$
 Wrap=�6E   $	��Top=�6Y   $	��312��6q   6�   �� 5   
   -   5        $ textMail��5      $��19��6$   $��93,50,187,0q�60   $
 Wrap=�6E   $	��Top=�6Y   $	��312��6q   6�   �� 5   
   -   5        $ textTel��5      $��19��6#   $��93,78,187,0q�6/   $
 Wrap=�6D   $	��Top=�6X   $	��312��6p   6   �� 5   
   -   5        $ 	textAnsch��5      $��19��6%   $��93,106,187,0q�61   $
 Wrap=�6G   $	��Top=�6[   $	��312��6s   6�   �� 5   
   $��Name:��6   $
��Left=�6    $��	10,18,0,0q�6;   $	��Top=�6N   $��79��6f   $��26��6q   �� 5   
   $��E-Mail:��6   $
��Left=�6"   $��	10,47,0,0q�6=   $	��Top=�6P   $��79��6h   $��26��6s   �� 5   
   $��Telefon:��6   $
��Left=�6#   $��	10,75,0,0q�6>   $	��Top=�6Q   $��79��6i   $��26��6t   �� 5   
   $��
Anschrift:��6   $
��Left=�6%   $��
10,103,0,0q�6@   $	��Top=�6T   $��79��6l   $��26��6w   �� 5   
   $��Right=�6   $��97��6,   $��	0,24,93,0q�68   $	��Top=�6K   $��81��6c   $��add.png��6n   �� 5   
   $��Right=�6   $��97��6,   $��0,24,8,0q�68   $	��Top=�6J   $��78��6b   $��del.png��6m   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGrid��5      $��	0,166,0,0q�6%      
IsReadOnly .    AutoGenerateColumns .  	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$

 Name��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6Q   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   ��  �� Path$
 name�6Q     5      $
 E-Mail��6%   $	 150 6T    65   �� $ email�6T     5      $
 Telefon��6%   $	 120 6S    66   �� $	 tel�6S     5      $
 	Anschrift��6%   $	 250 6[    68   �� $ 	anschrift�6[   5      �� 5   
   -   5         ��Name$	 add��5      $	��add��6   $��Right=�6,   $��97��6H   $��	0,24,93,0q�6T   $	��Top=�6g   $��81��6    J� Opacity$ 0Q�6�   �� 5    
   -   5        $ delete��5       $	��del��6!   $��Right=�6/   $��97��6K   $��0,24,8,0q�6W   $	��Top=�6i   $��81��6�   $��81��6�   $��97��6�   $ 0Q�6�   �� 5!   
   $��Suchen:��6   $
��Left=�6"   $��
10,134,0,0q�6=   $	��Top=�6Q   $��79��6i   $��26��6t   �� 5"   
   -	   5        $ 	textSuche��5"      $��19��6%   $��94,138,186,0q�61   $
 Wrap=�6G   $	��Top=�6[   $	��312��6s   6�   �� 5#   
   -
   5         ��Name$ 	editimage��5#      $��Right=�6#   $��42��6?   $��
0,115,71,0q�6K   $	��Top=�6_   $��45��6w   $��edit.png��6�   $ 0Q�6�   �� 5$   
   -   5        $
 edit��5$      $��Button��6   $��Right=�60   $��48��6L   $��
0,112,71,0q�6X   $	��Top=�6l   $��45��6�   $ 0Q�6�   5%      5&      