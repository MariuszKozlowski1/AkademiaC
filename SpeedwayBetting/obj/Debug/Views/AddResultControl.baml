   M S B A M L   `   `   `  ����J  FSpeedwayBetting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:SpeedwayBetting.ViewModelsSpeedwayBetting.ViewModels  5      ,    &SpeedwayBetting.Views.AddResultControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?
ViewModels(clr-namespace:SpeedwayBetting.ViewModels     5      
�������.��5
      �   � DataContext  5   
   3  -SpeedwayBetting.ViewModels.AddResultViewModel  5      .+�5   
   �� $��4��6   $��20(�5      $��
Add result��5       �� TextAlignment$ Center=�5      $
��Wrap=�5      &   System.Windows.Controls.DataGrid  5   
   $��0,30,0,60.338q�6      AutoGenerateColumns .     HeadersVisibility$ Column=�5         
IsReadOnly . ��5      �� *	MatchList+ �� SelectedItem 5      �� *SelectedMatch+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6%      Header$ ID��6F   	   
Visibility$	 Hidden=�6R   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6/   �� *ID+6R     5      $ * 6%   $ Hosts��6I   
 6/   �� *Hosts+6I     5      $ * 6%   $ Visitors��6L   
 6/   �� *
Visitors+6L     5      $ * 6%   $ Result��6J   
 6/   �� *Result+6J   5      �� 5    
   $��Result:��6   $
��Left=�6"   $��
10,250,0,0q�6=   $	��Top=�6Q   �� 5!   
   $
��Left=�6   $	��Top=�6.   $	��120��6F   $��23��6R   $��
55,250,0,0q�6^    �� 
IsEditable .  ��5#      �� *ResultsList+ 5$      �� *ResultToAdd+�� 5&   
   $��Add re_sult��6   $
��Left=�6'   $��190,250,0,0q�6B   $	��Top=�6W   $��75��6o   ��5'      �� *AddResultCommand+5(      5)      