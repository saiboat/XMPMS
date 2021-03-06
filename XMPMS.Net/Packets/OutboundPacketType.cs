﻿// ======================================================================
//  Unreal2 XMP Master Server
//  Copyright (C) 2010-2011  Adam Mummery-Smith
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.

//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.

//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.

//  Copyright Notice:
//  Unreal and the Unreal logo are registered trademarks of Epic
//  Games, Inc. ALL RIGHTS RESERVED.
// ======================================================================

namespace XMPMS.Net.Packets
{
    /// <summary>
    /// Type of outbound packet
    /// </summary>
    public enum OutboundPacketType
    {
        /// <summary>
        /// A TCP packet, header consists of a packet length and is transmitted via TCP
        /// </summary>
        TCP,

        /// <summary>
        /// A UDP packet, the header consists of an engine version and the packet is dispatched via UDP
        /// </summary>
        UDP
    }
}
