   M S B A M L   `   `   `  ����J  FSpeedwayBetting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:SpeedwayBetting.ViewModelsSpeedwayBetting.ViewModels  5      +    %SpeedwayBetting.Views.AddMatchControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?
ViewModels(clr-namespace:SpeedwayBetting.ViewModels     5      
�������.��5
      �   � DataContext  5   
   2  ,SpeedwayBetting.ViewModels.AddMatchViewModel  5      .+�5   
   �� $��4��6   $��20(�5      $��	Add match��5       �� TextAlignment$ Center=�5      $
��Wrap=�5      5      �� 5   
   $��Hosts:��6   $
��Left=�6!   $��	39,74,0,0q�6<   $	��Top=�6O   �� 5   
   $
��Left=�6   $	��Top=�6.   $	��120��6F   $��23��6R   $��
110,74,0,0q�6^    �� 
IsEditable .  $ �� IsSynchronizedWithCurrentItem$
 TrueY�5      ��5      �� *	TeamsList+ �� SelectedItem 5      �� *Match.Hosts+5      �� 5   
   $��	Visitors:��6   $
��Left=�6$   $��
39,105,0,0q�6?   $	��Top=�6S   �� 5   
   $
��Left=�6   $	��Top=�6.   $	��120��6F   $��23��6R   $��110,105,0,0q�6^    .  ��5      �� *	TeamsList+ 5      �� *Match.Visitors+�� 5    
   $��
Add ma_tch��6   $
��Left=�6&   $��139,151,0,0q�6A   $	��Top=�6V   $��75��6n   ��5!      �� *AddMatchCommand+5"      5#      