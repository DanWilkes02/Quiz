   M S B A M L   `   `   `  ����?  ;Quiz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Quiz.VeiwmodelsQuiz.Veiwmodels  5      'clr-namespace:Quiz.Veiws
Quiz.Veiws  5          Quiz.Veiws.FinishedVeiw   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4
veiwmodelsclr-namespace:Quiz.Veiwmodels     5      *localclr-namespace:Quiz.Veiws     5      .��5
      � 
�������  � ColumnDefinitions  5   
   �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   �� $��3��6   $��Center=�6(   $��35(�6E   Your Score:6`   �� 5   
   $��1��6   $��1��6!   $��35(�61    �� TextAlignment$ Center=�6?   ��6V   �� *ScoreModel.Score+�� 5   
   $��2��6   $��10 40q�6   $��AnalysisView��6�    � DataContext 6-   �� *ApplicationViewModel+��6Z   �� *ChangeViewCommand+.��6�   Go to analysis6�   �� 5   
   $��2��6   $��2��6   $��10 40q�6.   ��6=   �� *ExitCommand+.��6]   Exit6c   5      5      