﻿using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Automation;

namespace TextRPG.Engine.Models;

public class Player : INotifyPropertyChanged
{
    private string _name;
    private string _characterClass;
    private int _hitPoints;
    private int _experiencePoints;
    private int _level;
    private int _gold;

    public string Name
    {
        get => _name;
        set
        {
            _name = value;
            OnPropertyChanged(nameof(Name));
        }
    }

    public string CharacterClass
    {
        get => _characterClass;
        set
        {
            _characterClass = value;
            OnPropertyChanged(nameof(CharacterClass));
        } 
}

    public int HitPoints
    {
        get => _hitPoints;
        set
        {
            _hitPoints = value;
            OnPropertyChanged(nameof(HitPoints));
        }
    }

    public int ExperiencePoints
    {
        get => _experiencePoints;
        set
        {
            _experiencePoints = value;
            OnPropertyChanged(nameof(ExperiencePoints));
        }
    }

    public int Level
    {
        get => _level;
        set
        {
            _level = value;
            OnPropertyChanged(nameof(Level));
        }
    }

    public int Gold
    {
        get => _gold;
        set
        {
            _gold = value;
            OnPropertyChanged(nameof(Gold));
        }
    }
    public event PropertyChangedEventHandler? PropertyChanged;
    
    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}