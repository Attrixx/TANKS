# TANKS

Jean Michel Texture vous présente les ajouts que nous avans fait à ce projet. Tous nos contenus ajoutés se trouvent dans le dossier `.\Assets\_Tanks\Tutorial_Demo\JeanMichelTexture\`.

## Features

Nous avons ajouté des powerups reliés à des spawners disséminés sur la carte. Quand un power up est récupéré (il suffit de rentrer dedans pour le ramasser), un autre apparait après un délai sur le spawner. Ils sont au nombre de 2:

- **Speed Boost**: Donne un brève augmentation de vitesse au joueur.
- **Critical Hit**: Double les dégats infligés par le prochain tir du joueur.

Le déclenchement d'un coup critique fait aussi un court camera shake.

## Détails

Nous avons utilisé exclusivement la carte du désert, pour y incorporer un shader post processing de chaleur. Chaque tank est outliné et a des muzzles flashs à chaque tir. Quand un power up est récupéré, un indicateur le montre sur le tank (feu à l'arrière pour le boost, fumée au canon pour le coup critique). Quand un tank meurt, il explose. Chaque balle tirée explose à l'impact.  

## Shaders

### Lit / Unlit

**Shader_Cylinder**: L'effet qui entoure les powerups.

**Shader_Flame**: Effet de flamme qui sortent du pot d'échapement du tank pendant le boost de vitesse.

**Shader_Outliner** (HLSL): Effet de contour cartoon autour des tanks.

**Shader_PowerUp_Base**: Matériau de base pour le VFX de Power Up.

**Shader_Smoke**: Effet de fumée pour explosions / tirs.

### Post Processing

**Shader_CriticalHit**: Effet de distortion des couleurs quand un coup critique est infligé.

**Shader_Heatwaves**: Effet de chaleur dans le désert.

## VFX

**VFX_Explosion**: Explosion des balles à l'impact.

**VFX_Flames**: Effet de flammes à l'arrière du tank pendant le Speed Boost.

**VFX_MuzzleSmoke**: Effet de fumée indiquant que la prochaine balle sera critique.

**VFX_PowerUp**: Représentation des Power Ups.

**VFX_StylsedExplosion**: Explosion du tank à la mort.

**VFXG_MuzzleFlash**: Muzzle Flash au tir.

## Autres

Nous avons modifiés certains des scripts et prefabs déjà présents. Particulièrement ceux du Tank de base.

Les meshes des muzzles flashs, cylidres de contour des power ups et particules de fumée ont été réalisés par nos soins sur Blender.

A l'éxception du CloudNoise et du MuzzleFlash, nous avons également fait nos propres textures.

Enfin, nous avons ajoutés quelques SFX pour le game feel. (Bruits d'explosions, de flammes et de coup critique).
