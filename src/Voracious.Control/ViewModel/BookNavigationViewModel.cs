﻿using CommunityToolkit.Mvvm.ComponentModel;

using Voracious.Core.Enum;
using Voracious.Core.Model;

namespace Voracious.Control.ViewModel;

public partial class BookNavigationViewModel : ObservableObject
{
    [ObservableProperty]
    private int id;

    [ObservableProperty]
    private ResourceCore resource;

    [ObservableProperty]
    private DateTime mostRecentNavigationDate = DateTime.Now;

    [ObservableProperty]
    private int numberOfCatalogViews;

    [ObservableProperty]
    private int numberOfSwipeRight;

    [ObservableProperty]
    private int numberOfSwipeLeft;

    [ObservableProperty]
    private int numberReading;

    [ObservableProperty]
    private int numberSpecificSelection;

    [ObservableProperty]
    private string currentSpot = "";

    [ObservableProperty]
    private UserStatusEnum currentStatus = UserStatusEnum.NoStatus;

    [ObservableProperty]
    private DateTime timeMarkedDone = DateTime.MinValue;

    [ObservableProperty]
    private DateTime firstNavigationDate = DateTime.Now;

    [ObservableProperty]
    private bool isDone = false;
}
