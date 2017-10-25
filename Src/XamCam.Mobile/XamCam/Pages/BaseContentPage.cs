﻿using Xamarin.Forms;

namespace XamCam
{
    public class BaseContentPage<T> : ContentPage where T : BaseViewModel, new()
    {
        public BaseContentPage()
        {
            BindingContext = new T();
            this.SetBinding(IsBusyProperty, nameof(ViewModel.IsInternetConnectionActive));
        }

        protected T ViewModel => BindingContext as T;
    }
}