   M S B A M L   `   `   `  ����I  EWpfTaskmanager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WpfTaskmanagerWpfTaskmanager  5      &     WpfTaskmanager.View.AddNote_page   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:WpfTaskmanager     5        N� WindowTitle$  Task Manager��5       N� WindowHeight$	 400Q�6#    N� WindowWidth$	 510Q�66   .��5
      � ��5   
   �� 5       �� ImageSource$2 ,pack://application:,,,/images/background.jpg��6    � RowDefinitions 5   
   �� 5      $
��0.5* �6   �� 5      $��* �6   �� 5      $��3* �6   �� 5      .+�5   
   c� $��0��6   $��Right=�6   $	��Top=�6;   .@�5      �� $��50��6   $
��Save��6       SaveButtonStyle#��[  5      {�5      �� *SaveNew_ButtonVisibility+��5      �� *SaveNewNote_Command+5      �� 5   
   $��1��6   $��	10 5 10 0q�6   $��40��5      $
��Left=�6   $��Topic:��5      �� 5   
   $��1��6   $��	55 5 10 0q�6    �� TextWrapping$
 Wrap=�5        TopicTextBoxStyle#��[ 5      ��5       �� *NewNote.Topic+ �� Mode$ TwoWay=��� 5!   
   $��2��6   $��	10 5 10 0q�6   $
 Wrap=�5"        TaskTextTextBoxStyle#��[ 5#      ��5$      �� *NewNote.Text+$ TwoWay=�5%      5&      