   M S B A M L   `   `   `  ����?  ;Quiz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Quiz.Veiws
Quiz.Veiws  5          Quiz.Veiws.QuizVeiw   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:Quiz.Veiws     5      .��5
   
   � 
�������  � ColumnDefinitions  5   
   �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      .+�5   
   ]� $��3��6   $��0��6(   .+�5      �� $��0��6   $��0��6(   $
��Left=�65   $��30(�6K   $��2,0,5,0q�6Y   ��6j   �� *ScoreModel.Score+ �� UpdateSourceTrigger$ PropertyChanged=��� 5      $��Center=�6   $��20(�65   $
��Wrap=�6C   ��6W   �� *CurrentQuestion.Question+5      �� 5   
   $��1��6   $��1��6!   $
��25px��6.   $��1��6�   ��6<   �� *" CurrentQuestion.AnswerChoices[0]+��6q   �� *AnswerCommand+6�   �� 5   
   $��1��6   $��2��6!   $
��25px��6.   $��2��6�   ��6<   �� *" CurrentQuestion.AnswerChoices[1]+��6q   �� *AnswerCommand+6�   �� 5   
   $��1��6   $��3��6!   $
��25px��6.   $��3��6�   ��6<   �� *" CurrentQuestion.AnswerChoices[2]+��6q   �� *AnswerCommand+6�   5       5!      