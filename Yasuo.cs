if myHero.charName ~= "Yasuo" then return end
 
local wSpells = {
        ["Aatrox"] = {
                skills = {
                        ["AatroxE"] = {range = 1000, radius = 75, castDelay = 0, danger = 2, skillshot = true, type = "line"}
                }
        },
        ["Ahri"] = {
                skills = {
                        ["AhriSeduce"] = {range = 975, radius = 60, castDelay = 0, danger = 3, skillshot = true, type = "line"}
                }
        },
        ["Amumu"] = {
                skills = {
                        ["BandageToss"] = {range = 1100, radius = 80, castDelay = 0, danger = 3, skillshot = true, type = "line"}
                }
        },
        ["Anivia"] = {
                skills = {
                        ["FlashFrostSpell"] = {range = 1100, radius = 110, castDelay = 0, danger = 3, skillshot = true, type = "line"}
                }
        },
        -- annie
        ["Blitzcrank"] = {
                skills = {
                        ["RocketGrabMissile"] = {range = 925, radius = 70, castDelay = 0, danger = 3, skillshot = true, type = "line"}
                }
        },
        ["Brand"] = {
                skills = {
                        ["BrandBlaze"] = {range = 1050, radius = 80, castDelay = 0, danger = 3, skillshot = true, type = "line"}
                        -- ult too
                }
        },
        ["Caitlyn"] = {
                skills = {
                        ["CaitlynPiltoverPeacemaker"] = {range = 1250, radius = 90, castDelay = 0, danger = 1, skillshot = true, type = "line"}
                        -- ult too
                }
        },
        ["Corki"] = {
                skills = {
                        ["MissileBarrage"] = {range = 1225, radius = 40, castDelay = 0, danger = 1, skillshot = true, type = "line"},
                        ["MissileBarrage!"] = {range = 1225, radius = 40, castDelay = 0, danger = 1, skillshot = true, type = "line"}
                }
        },
        ["Mundo"] = {
                skills = {
                        ["InfectedCleaverMissile"] = {range = 900, radius = 75, castDelay = 0, danger = 2, skillshot = true, type = "line"}
                }
        },
        ["Draven"] = {
                skills = {
                        ["DravenDoubleShot"] = {range = 1050, radius = 130, castDelay = 0, danger = 2, skillshot = true, type = "line"}
                }
        },
        ["Elise"] = {
                skills = {
                        ["EliseHumanE"] = {range = 1075, radius = 70, castDelay = 0, danger = 3, skillshot = true, type = "line"}
                }
        },
        ["Ezreal"] = {
                skills = {
                        ["EzrealMysticShot"] = {range = 1150, radius = 80, castDelay = 0, danger = 1, skillshot = true, type = "line"}
                }
        },
        ["Fizz"] = {
                skills = {
                        ["FizzMarinerDoom"] = {range = 1275, radius = 80, castDelay = 0, danger = 5, skillshot = true, type = "line"}
                }
        },
        -- Gragas
        -- Graves
        -- Heim
        -- Irelia
        -- Jayce
        ["Jinx"] = {
                skills = {
                        ["JinxWMissile"] = {range = 1450, radius = 70, castDelay = 0, danger = 2, skillshot = true, type = "line"},
                        ["JinxRWrapper"] = {range = 2000, radius = 1200, castDelay = 0, danger = 4, skillshot = true, type = "line"}
                }
        },
        ["Karma"] = {
                skills = {
                        ["KarmaQ"] = {range = 950, radius = 90, castDelay = 0, danger = 2, skillshot = true, type = "line"}
                }
        },
        -- Kassadin
        -- Kayle
        ["Kennen"] = {
                skills = {
                        ["KennenShurikenHurlMissile1"] = {range = 950, radius = 50, castDelay = 0, danger = 3, skillshot = true, type = "line"}
                }
        },
        ["Leblanc"] = {
                skills = {
                        ["LeblancSoulShackle"] = {range = 925, radius = 70, castDelay = 0, danger = 3, skillshot = true, type = "line"}
                }
        },
        ["LeeSin"] = {
                skills = {
                        ["BlindMonkQOne"] = {range = 1000, radius = 70, castDelay = 0, danger = 3, skillshot = true, type = "line"}
                }
        },
        ["Lucian"] = {
                skills = {
                        ["LucianQ"] = {range = 550, radius = 65, castDelay = 0, danger = 1, skillshot = true, type = "line"},
                        ["LucianW"] = {range = 1000, radius = 80, castDelay = 0, danger = 1, skillshot = true, type = "line"}
                        -- ult too
                }
        },
        ["Lux"] = {
                skills = {
                        ["LuxLightBinding"] = {range = 1175, radius = 80, castDelay = 0, danger = 3, skillshot = true, type = "line"}
                }
        },
        -- Malphite
        -- Maokai
        -- Miss fortune
        ["Morgana"] = {
                skills = {
                        ["DarkBindingMissile"] = {range = 1175, radius = 80, castDelay = 0, danger = 3, skillshot = true, type = "line"}
                }
        },
        ["Nami"] = {
                skills = {
                        ["NamiQ"] = {range = 875, radius = 225, castDelay = 0, danger = 2, skillshot = true, type = "circular"}
                        -- ult too
                }
        },
        ["Nautilus"] = {
                skills = {
                        ["NautilusAnchorDrag"] = {range = 950, radius = 80, castDelay = 0, danger = 3, skillshot = true, type = "line"}
                }
        },
        ["Nidalee"] = {
                skills = {
                        ["JavelinToss"] = {range = 1500, radius = 60, castDelay = 0, danger = 2, skillshot = true, type = "line"}
                }
        },
        ["Nocturne"] = {
                skills = {
                        ["NocturneDuskbringer"] = {range = 1125, radius = 60, castDelay = 0, danger = 1, skillshot = true, type = "line"}
                }
        },
        ["Olaf"] = {
                skills = {
                        ["OlafAxeThrow"] = {range = 1000, radius = 90, castDelay = 0, danger = 2, skillshot = true, type = "line"}
                }
        },
        -- Orianna
        -- Pantheon
        ["Quinn"] = {
                skills = {
                        ["QuinnQ"] = {range = 1025, radius = 80, castDelay = 0, danger = 3, skillshot = true, type = "line"}
                }
        },
        -- Rengar
        -- Riven
        ["Rumble"] = {
                skills = {
                        ["RumbleGrenade"] = {range = 850, radius = 90, castDelay = 0, danger = 2, skillshot = true, type = "line"}
                }
        },
        -- Sejuani
        -- Shaco
        -- Shen
        -- Shyvana
        -- Sion
        ["Sivir"] = {
                skills = {
                        ["SivirQ"] = {range = 1075, radius = 100, castDelay = 0, danger = 2, skillshot = true, type = "line"}
                }
        },
        -- Sona
        -- Syndra
        -- Talon
        -- Taric
        -- Teemo
        -- Tresh
        -- Tristana
        -- Twisted fate
        -- Twitch
        -- Urgot
        ["Varus"] = {
                skills = {
                        ["VarusR"] = {range = 1100, radius = 100, castDelay = 0, danger = 5, skillshot = true, type = "line"}
                }
        },
        -- Veigar
        -- Vi
        ["Viktor"] = {
                skills = {
                        ["ViktorDeathRay!"] = {range = 540, radius = 80, castDelay = 0, danger = 2, skillshot = true, type = "line"}
                }
        },
        ["Yasuo"] = {
                skills = {
                        ["yasuoq3w"] = {range = 900, radius = 150, castDelay = 0, danger = 3, skillshot = true, type = "line"}
                }
        },
        ["Zed"] = {
                skills = {
                        ["ZedShuriken"] = {range = 900, radius = 50, castDelay = 0, danger = 1, skillshot = true, type = "line"}
                }
        },
        ["Ziggs"] = {
                skills = {
                        ["ZiggsQ"] = {range = 850, radius = 100, castDelay = 0, danger = 1, skillshot = true, type = "line"}
                }
        },
        ["Zyra"] = {
                skills = {
                        ["ZyraGraspingRoots"] = {range = 1100, radius = 70, castDelay = 0, danger = 3, skillshot = true, type = "line"},
                        ["zyrapassivedeathmanager"] = {range = 1500, radius = 60, castDelay = 0, danger = 1, skillshot = true, type = "line"}
                }
        },
}
 
local enemyMinions = {}
local qdelay, qspeed, qspeed2 = 100, 1.8, 1.4
local qLast = 0
 
function OnLoad()
        HConfig = scriptConfig("Yasuo Combo", "YasuoCombo")
        HConfig:addParam("scriptActive", "Team Fight", SCRIPT_PARAM_ONKEYDOWN, false, 32)
        HConfig:addParam("autoQ", "Auto Q Harass", SCRIPT_PARAM_ONOFF, true)
        HConfig:addParam("autoW", "Auto W Shield", SCRIPT_PARAM_ONOFF, true)
        HConfig:addParam("autoR", "Use Ult", SCRIPT_PARAM_ONOFF, true)
        HConfig:addParam("following", "Follow while combo", SCRIPT_PARAM_SLICE, 1, 0, 1)
       
        for i=1, heroManager.iCount do
                local enemy = heroManager:GetHero(i)
                if enemy.team ~= myHero.team then
                        HConfig:addParam("focus"..enemy.charName, "High priority focus "..enemy.charName, SCRIPT_PARAM_ONOFF, true)
                end
        end
 
        enemyMinions = minionManager(MINION_ENEMY, 475, myHero, MINION_SORT_HEALTH_DES)
       
        HConfig:permaShow("scriptActive")
       
        PrintChat(" >> Yasuo Combo by HunteR")
end
 
function OnTick()
        if myHero.dead then
                return
        end
       
        if HConfig.scriptActive then
                combo()
        else
                if HConfig.autoQ and myHero:CanUseSpell(_Q) == READY then
                        local enemyF = {}
                        local qRange = 475
                        local qName = myHero:GetSpellData(_Q).name
                        local speedQ = qspeed
                        if qName == "yasuoq3w" then
                                qRange = 900
                                speedQ = qspeed2
                        end
                       
                        for i=1, heroManager.iCount do
                                local enemy = heroManager:GetHero(i)
                                if enemy.team ~= myHero.team and ValidTarget(enemy, qRange) then
                                        enemyF[math.floor(enemy.health / getDmg("AD", enemy, myHero))] = enemy
                                end
                        end
                       
                        for hits, enemy in pairsByKeys(enemyF) do
                                local travelDuration = (qdelay + GetDistance(myHero, enemy)/speedQ)
                                travelDuration = (qdelay + GetDistance(GetPredictionPos(enemy, travelDuration))/speedQ)
                                travelDuration = (qdelay + GetDistance(GetPredictionPos(enemy, travelDuration))/speedQ)
                                travelDuration = (qdelay + GetDistance(GetPredictionPos(enemy, travelDuration))/speedQ)      
                                local prediction = GetPredictionPos(enemy, travelDuration)
                                if prediction ~= nil then
                                        local predDistX = enemy.x - prediction.x
                                        local predDistY = enemy.y - prediction.y
                                        local predDist = (predDistX * predDistX + predDistY * predDistY)^0.5
                                        if prediction ~= nil and predDist < 300 then
                                                if GetDistance(myHero, prediction) < qRange and (qName ~= "yasuoq3w" or os.clock() > qLast or GetDistance(myHero, prediction) < 300) then
                                                        CastSpell(_Q, prediction.x, prediction.z)
                                                end
                                        end
                                end
                                break
                        end
                end
        end
end
 
function pairsByKeys (t, f)
        local a = {}
        for n in pairs(t) do table.insert(a, n) end
        table.sort(a, f)
        local i = 0      -- iterator variable
        local iter = function ()   -- iterator function
                i = i + 1
                if a[i] == nil then return nil
                else return a[i], t[a[i]]
                end
        end
        return iter
end
 
function dodgelinepass(pos1, pos2, radius, maxDist)
        local pm2x = pos1.x + (maxDist)/(math.floor(math.sqrt((pos1.x-pos2.x)^2 + (pos1.z-pos2.z)^2)))*(pos2.x-pos1.x)
    local pm2z = pos1.z + (maxDist)/(math.floor(math.sqrt((pos1.x-pos2.x)^2 + (pos1.z-pos2.z)^2)))*(pos2.z-pos1.z)
    local calc1 = (math.floor(math.sqrt((pm2x-player.x)^2 + (pm2z-player.z)^2)))
    local calc2 = (math.floor(math.sqrt((pos1.x-player.x)^2 + (pos1.z-player.z)^2)))
    local calc3
    local calc4 = (math.floor(math.sqrt((pos1.x-pm2x)^2 + (pos1.z-pm2z)^2)))
    local k
    local x4
    local z4
    local dodgex
    local dodgez
    local perpendicular = (math.floor((math.abs((pm2x-pos1.x)*(pos1.z-player.z)-(pos1.x-player.x)*(pm2z-pos1.z)))/(math.sqrt((pm2x-pos1.x)^2 + (pm2z-pos1.z)^2))))
    k = ((pm2z-pos1.z)*(player.x-pos1.x) - (pm2x-pos1.x)*(player.z-pos1.z)) / ((pm2z-pos1.z)^2 + (pm2x-pos1.x)^2)
        x4 = player.x - k * (pm2z-pos1.z)
        z4 = player.z + k * (pm2x-pos1.x)
        calc3 = (math.floor(math.sqrt((x4-player.x)^2 + (z4-player.z)^2)))
        dodgex = x4 + ((radius+150)/calc3)*(player.x-x4)
    dodgez = z4 + ((radius+150)/calc3)*(player.z-z4)
    if perpendicular <= (radius + 100) and calc1 <= calc4 and calc2 <= calc4 then
        return true
        else
                return false
    end
       
end
 
function OnProcessSpell(obj, spell)
        if myHero.dead then return end
       
        if obj == myHero then
                if spell.name == "yasuoq2w" then
                        qLast = os.clock() + 4 + math.random(3)
                end
        elseif HConfig.autoW and myHero:CanUseSpell(_W) == READY and obj.team ~= myHero.team and string.find(spell.name, "Basic") == nil then
                if wSpells[obj.charName] ~= nil then
                        if wSpells[obj.charName].skills[spell.name] ~= nil then
                                local rangeChamps = -1
                                local maxDanger = -1
                                for i=1, heroManager.iCount do
                                        local enemy = heroManager:GetHero(i)
                                        if ValidTarget(enemy) and wSpells[enemy.charName] ~= nil then
                                                for spella, info in pairs(wSpells[enemy.charName].skills) do
                                                        if rangeChamps < info.range then
                                                                rangeChamps = info.range
                                                        end
                                                       
                                                        if maxDanger < info.danger then
                                                                maxDanger = info.danger
                                                        end
                                                end
                                        end
                                end
                               
                                local range = wSpells[obj.charName].skills[spell.name].range
                                if GetDistance(myHero, spell.startPos) <= range and (CountEnemyHeroInRange(rangeChamps) == 1 or (wSpells[obj.charName].skills[spell.name].danger >= (maxDanger - 1) and wSpells[obj.charName].skills[spell.name].danger > 2)) then
                                        if dodgelinepass(spell.startPos, spell.endPos, wSpells[obj.charName].skills[spell.name].radius, range) then
                                                CastSpell(_W, obj.x, obj.z)
                                        end
                                end
                        end
                end
        end
end
 
function eDash(target)
        local dPredict = myHero:GetDistance(target)
       
        local xE = myHero.x + (497 / dPredict) * (target.x - myHero.x)
        local zE = myHero.z + (497 / dPredict) * (target.z - myHero.z)
       
        local returna = {}
        returna.x = xE
        returna.z = zE
        return returna
end
 
function combo()
        local QREADY = (myHero:CanUseSpell(_Q) == READY)
        local WREADY = (myHero:CanUseSpell(_W) == READY)
        local EREADY = (myHero:CanUseSpell(_E) == READY)
        local RREADY = (myHero:CanUseSpell(_R) == READY)
       
        local TIAMATSlot = GetInventorySlotItem(3077)
        local TIAMATREADY = (TIAMATSlot ~= nil and myHero:CanUseSpell(TIAMATSlot) == READY)
        local HYDRASlot = GetInventorySlotItem(3074)
        local HYDRAREADY = (HYDRASlot ~= nil and myHero:CanUseSpell(HYDRASlot) == READY)
        local BLADESLot = GetInventorySlotItem(3153)
        local BLADEREADY = (BLADESLot ~= nil and myHero:CanUseSpell(BLADESLot) == READY)
        local BILGESlot = GetInventorySlotItem(3144)
        local BILGEREADY = (BILGESlot ~= nil and myHero:CanUseSpell(BILGESlot) == READY)
        local RANDSlot = GetInventorySlotItem(3143)
        local RANDREADY = (RANDSlot ~= nil and myHero:CanUseSpell(RANDSlot) == READY)
        local bladeaSlot = GetInventorySlotItem(3142)
        local bladeaaREADY = (bladeaSlot ~= nil and myHero:CanUseSpell(bladeaSlot) == READY)
 
        if HConfig.autoR and RREADY then
                local ulti = false
                for i = 1, heroManager.iCount, 1 do
                        local rTarget = heroManager:getHero(i)
                        if ValidTarget(rTarget, 1300) and HConfig["focus"..rTarget.charName] then
                                ulti = true
                        end
                end
               
                if ulti then CastSpell(_R) end
        end
       
        local focusEnemy = nil
        local minimumHit = -1
        local lowPriority = false
       
        local qName = myHero:GetSpellData(_Q).name
       
        for i=1, heroManager.iCount do
            local target = heroManager:GetHero(i)
            if ValidTarget(target, 1500) then
                        local dmg = getDmg("AD", target, myHero)
                        local hits = (target.health / dmg)
                        if minimumHit == -1 or (hits < minimumHit and HConfig["focus"..target.charName]) or hits <= 1.05 or (not lowPriority and minimumHit > 1.05) then
                                focusEnemy = target
                                minimumHit = hits
                                lowPriority = HConfig["focus"..target.charName]
                        end
            end
        end
       
        if focusEnemy ~= nil then
                if EREADY then
                        if myHero:GetDistance(focusEnemy) < 475 and not TargetHaveBuff("YasuoDashWrapper", focusEnemy) then
                                if myHero:GetDistance(focusEnemy) > 200 and ((myHero:GetDistance(focusEnemy) > 350 and myHero:GetDistance(focusEnemy) < GetDistance(myHero, GetPredictionPos(focusEnemy, 500))) or (getDmg("Q", focusEnemy, myHero) + getDmg("E", focusEnemy, myHero)) > focusEnemy.health) then
                                        CastSpell(_E, focusEnemy)
                                        return
                                end
                        else
                                local eTarget = nil
                               
                                enemyMinions:update()
                               
                                local minimumDist = -1
                                for i, minion in pairs(enemyMinions.objects) do
                                        if minion ~= nil and minion.valid then
                                                local distMin = GetDistance(eDash(minion), focusEnemy)
                                                if (distMin < minimumDist or minimumDist == -1) and myHero:GetDistance(focusEnemy) > distMin and not TargetHaveBuff("YasuoDashWrapper", minion) then
                                                        eTarget = minion
                                                        minimumDist = distMin
                                                end
                                        end
                                end
                               
                                if not TargetHaveBuff("YasuoDashWrapper", focusEnemy) then
                                        if eTarget == nil then
                                                for i=1, heroManager.iCount do
                                                        local target = heroManager:GetHero(i)
                                                        if ValidTarget(target, 475) and target ~= focusEnemy and GetDistance(eDash(target), focusEnemy) < 475 and not TargetHaveBuff("YasuoDashWrapper", target) then
                                                                eTarget = target
                                                                break
                                                        end
                                                end
                                        end
                                end
                               
                                if eTarget ~= nil then
                                        CastSpell(_E, eTarget)
                                        return
                                else
                                        local minimumHit = -1
                                        local lowPriority = false
                                       
                                        for i=1, heroManager.iCount do
                                                local target = heroManager:GetHero(i)
                                                if ValidTarget(target, 475) then
                                                        local dmg = getDmg("AD", target, myHero)
                                                        local hits = (target.health / dmg)
                                                        if minimumHit == -1 or (hits < minimumHit and HConfig["focus"..target.charName]) or hits <= 1.05 or (not lowPriority and minimumHit > 1.05) then
                                                                focusEnemy = target
                                                                minimumHit = hits
                                                                lowPriority = HConfig["focus"..target.charName]
                                                        end
                                                end
                                        end
                                end
                        end
                end
       
                if QREADY then
                        local qRange = 475
                        local speedQ = qspeed
                        if qName == "yasuoq3w" then
                                qRange = 900
                                speedQ = qspeed2
                        end
                       
                        local travelDuration = (qdelay + GetDistance(myHero, focusEnemy)/speedQ)
                        travelDuration = (qdelay + GetDistance(GetPredictionPos(focusEnemy, travelDuration))/speedQ)
                        travelDuration = (qdelay + GetDistance(GetPredictionPos(focusEnemy, travelDuration))/speedQ)
                        travelDuration = (qdelay + GetDistance(GetPredictionPos(focusEnemy, travelDuration))/speedQ)      
                        local prediction = GetPredictionPos(focusEnemy, travelDuration)
                        if prediction ~= nil then
                                local predDistX = focusEnemy.x - prediction.x
                                local predDistY = focusEnemy.y - prediction.y
                                local predDist = (predDistX * predDistX + predDistY * predDistY)^0.5
                               
                                if GetDistance(myHero, prediction) < qRange and predDist < 300 then
                                        CastSpell(_Q, prediction.x, prediction.z)
                                        return
                                end
                        end
                end
               
                if BILGEREADY and myHero:GetDistance(focusEnemy) < 450 and HConfig["focus"..focusEnemy.charName] then
                        CastSpell(BILGESlot, focusEnemy)
                        return
                end
               
                if BLADEREADY and myHero:GetDistance(focusEnemy) < 450 and HConfig["focus"..focusEnemy.charName] then
                        CastSpell(BLADESLot, focusEnemy)
                        return
                end
               
                if TIAMATREADY and CountEnemyHeroInRange(350) >= 1 then
                        CastSpell(TIAMATSlot)
                        return
                end
               
                if HYDRAREADY and (CountEnemyHeroInRange(350) >= 2 or (getDmg("AD", focusEnemy, myHero) < focusEnemy.health and CountEnemyHeroInRange(350) == 1)) then
                        CastSpell(HYDRASlot)
                        return
                end
               
                if RANDREADY and CountEnemyHeroInRange(450) >= 1 then
                        CastSpell(RANDSlot)
                        return
                end
               
                myHero:Attack(focusEnemy)
                return
        end
       
        if HConfig.following == 1 then
                myHero:MoveTo(mousePos.x, mousePos.z)
        end
end
 
function OnDraw()
       
end
