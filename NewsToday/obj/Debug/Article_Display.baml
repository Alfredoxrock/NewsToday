   M S B A M L   `   `   `  ����D  @NewsToday, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:NewsToday	NewsToday  5   	       NewsToday.Article_Display   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:NewsToday     5   	     � Title$  Enews��5   	   $
��5000��6   $��1388.303��6%    � WindowState$ 	Maximized=�66   .��5
      � $
��Auto=�6   
������ .+�5   
   �� .+�5      �� -   5         ��Name$ Headline_BackgroundColor��5      
���  ��$	��400��6H   �� 5      
�������$��0,420,-0.5,0.5q�6(   5      �� 5   
   $��0,0,-0.5,10.5q�6   .��5      �� $
��Left=�6   $
��Auto��64   $	��Top=�6B   $
��1333��6Z   
������ .+�5      �� -   5         ��Name$ Label_Category��5   +   $��CATEGORY��6   $��Center=�6C   $
��Left=�6e   $��Center=�6�   $��	568,0,0,0q�6�   $	��Top=�6�   $��Arial Black)�6�   $��20(�6�   
�������$	��220��6	  $��84��6  �� 5      -   5         ��Name$ Textblock_Headline��5      $��0q�66   $
��Left=�6J   $
��Auto��6e   $��Center=�6s    �� TextWrapping$
 Wrap=�6�   $��TextBox��6�   $
��1163��6�   $��Century Gothic)�6�   $��60(�6�   $
��Bold"�6�   $	��Top=�6  $��	108,0,0,0q�6   �� 
IsReadOnly . 
������ 
�������6Y  �� 5      -   5        $ Textbox_Byline��5       . $��0q�6D   $
��Left=�6X   
�������$��Center=�6�   $��48��6�   $
 Wrap=�6�   $��Byline��6�   $	��Top=�6�   $
��1163��6�   $��Century Gothic)�6�   $��20(�6  $��	108,0,0,0q�6'  
������ 6:  �� 5      $
��Left=�6   $
��Wrap=�67   $�� ��6K   $	��Top=�6S   $��34��6k   $	��228��6w   $��	598,0,0,0q�6�   � 5      $��Center=�6   $	��524��64   $��	43,0,62,0q�6A   $	��Top=�6T   $
��1228��6l   .+�5      �� -   5         ��Name$ Image_ArticleCover��5      $
��Fill=�68   $
��Left=�6G   $
��1163��6b   $��89,10,-24,-10q�6o   5      � 5      
�������$��	0,0,-37,0q�6*   .+�5       �� 
�������
�������$��0q�6D   $��46��6X   $��	0,0,-49,0q�6d   �� 5!      -   5        $ Textbox_AuthorAndTime��5!       . $��AUTHOR��6O   $��0q�6]   $��26(�6q   
�������$��Right=�6�   $��0,0,62,0q�6�   5"      � 5$      
�������$��	0,0,-26,0q�6*   .+�5%      �� -   5         ��Name$  RichTextBox_ArticleDisplay��5%   "   $��0q�6F   $
��Left=�6Z   $
��Auto��6u   $	��Top=�6�   $
��1163��6�   $��	108,0,0,0q�6�   . �5&      /� .T�5'      J� .*�6(   .*�5(   "   �� $� ��6&   5)      5*      5+      5,      �� 5.      -   5        	 ��Name$	 Button_Return��5.      $��60��60   
 � Cursor$

 Hand��6<      RoundButtonTemplate#��[  6J   $	��400��6w   $��RETURN��6�   $��Century Gothic)�6�   
�������
���  ��$��28(�6�   $��0q�6�   $��466,0,467,0q�6�   6  51      53      56      57      