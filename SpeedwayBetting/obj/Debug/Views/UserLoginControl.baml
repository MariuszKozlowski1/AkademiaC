   M S B A M L   `   `   `  ����J  FSpeedwayBetting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:SpeedwayBetting.HelpersSpeedwayBetting.Helpers  5      ,    &SpeedwayBetting.Views.UserLoginControl   5      0helper%clr-namespace:SpeedwayBetting.Helpers  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      
�������.��5
      � .+�5   
   �� $��Login:��6   $
��Left=�6!   $��	39,74,0,0q�6<   $	��Top=�6O   �� 5   
   $
��Left=�6   $��23��6-   $��
115,77,0,0q�69     �� TextWrapping$
  Wrap=�6M   $	��Top=�5      $	��120��6    J� RenderTransformOrigin$ 0.683,-0.609&�6(   ��5      �� *
User.Login+5   (   �� 5   
   $��	Password:��6   $
��Left=�6$   $��
39,105,0,0q�6?   $	��Top=�6S   G� 5   
   $
��Left=�6   $	��Top=�61   $	��120��5      $��23��6"   $��115,105,0,0q�6.   2   ,SpeedwayBetting.Helpers.PasswordBoxAssistant   BindPassword .    BoundPassword 5      �� *User.Password+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5   
   $��_Login��6   $
��Left=�6"   $��
39,151,0,0q�6=   $	��Top=�6Q   $	��190��6i   ��5      �� *LoginCommand+�� 5   
   $��_Registration��6   $
��Left=�6)   $��
39,191,0,0q�6D   $	��Top=�6X   $��75��6p   ��5      �� *ShowRegistrationCommand+�� 5   
   $��_Exit��6   $
��Left=�6!   $��154,191,0,0q�6<   $	��Top=�6Q   $��75��6i   ��5      �� *ExitCommand+5      5      