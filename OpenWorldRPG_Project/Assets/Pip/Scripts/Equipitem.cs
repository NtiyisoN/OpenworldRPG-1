﻿using UnityEngine;

[CreateAssetMenu]
public class Equipitem : Item
{
    [Header("Flat")]
    public int m_strbonus;
    public int m_agibonus;
    public int m_intbonus;
    public int m_vitbonus;
    [Space]
    [Header("Percent")]
    public float m_strperbonus;
    public float m_agiperbonus;
    public float m_intperbonus;
    public float m_vitperbonus;

    public enum Types
    {
        Head,
        Neck,
        Ring,
        Chest,
        Weapon,
        Shield,
        Legs,
        Feet
    };

    public Types m_type;

    public void Equiped(Character _char)
    {
        if(m_strbonus !=0)
            _char.m_strength.StatModify(new StatModify(m_strbonus, Modtostats.Flat, this));
        if (m_agibonus != 0)
            _char.m_agility.StatModify(new StatModify(m_agibonus, Modtostats.Flat, this));
        if (m_intbonus != 0)
            _char.m_intelligence.StatModify(new StatModify(m_intbonus, Modtostats.Flat, this));
        if (m_vitbonus != 0)
            _char.m_vitality.StatModify(new StatModify(m_vitbonus, Modtostats.Flat, this));


        if (m_strperbonus != 0)
            _char.m_strength.StatModify(new StatModify(m_strperbonus, Modtostats.Percentmult, this));
        if (m_agiperbonus != 0)
            _char.m_agility.StatModify(new StatModify(m_agiperbonus, Modtostats.Percentmult, this));
        if (m_intperbonus != 0)
            _char.m_intelligence.StatModify(new StatModify(m_intperbonus, Modtostats.Percentmult, this));
        if (m_vitperbonus != 0)
            _char.m_vitality.StatModify(new StatModify(m_vitperbonus, Modtostats.Percentmult, this));

    }

    public void Unequiped(Character _char)
    {

    }
}
